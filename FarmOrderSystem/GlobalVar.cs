using System;
using System.Collections.Generic;

namespace FarmOrderSystem
{
    public class GlobalVar
    {   
        // ── 資料庫連線字串
        public static string strDBConnectionString = "Data Source=.;Initial Catalog=FarmOrderDB;Integrated Security=True;";

        // ── 圖檔路徑
        public static string imageDir = @"C:\Hana's code\小專\確定版\FarmOrderSystem\FarmOrderSystem\Images";

        // ── 購物車（跨 Form 共用，Key = ProductID）
        public static Dictionary<int, CartItem> Cart = new Dictionary<int, CartItem>();

        //  ── 權限設計
        // 1-10：管理員  11-20：老闆  21-30：店員  31-40：會員  0：訪客
        public static int 使用者權限 = 0;
        public static string 使用者名稱 = "";

        // ── 折扣資訊
        public static int CurrentDiscountID = 0;
        public static string CurrentDiscountName = "原價(不折扣)";
        public static string CurrentDiscountType = "NONE";  // NONE / BOGO / THRESHOLD
        public static double CurrentDiscountRate = 1.0;     // 折扣率用 double（0.9/0.85），計算後取整數
        public static int CurrentMinAmount = 0;
        public static bool CurrentIsBogo = false;

        // ── 會員資訊（訪客時 = 0 / 空字串）
        public static int CurrentMemberID = 0;
        public static string CurrentMemberName = "";
        public static string CurrentMemberPhone = "";

        // ── 系統常數
        public static int DeliveryFee = 100;
        public static int FreeDeliveryMin = 1000;

        // ── 老闆後台登入狀態
        public static bool IsAdminLoggedIn = false;
        public static string AdminAccount = "";

        // ── 工具方法

        public static void ClearCart()
        {
            Cart.Clear();
        }

        public static int GetCartCount()
        {
            int total = 0;
            foreach (CartItem item in Cart.Values)
                total += item.Quantity;
            return total;
        }

        public static int GetSubTotal()
        {
            int sub = 0;
            foreach (CartItem item in Cart.Values)
                sub += item.LineTotal;
            return sub;
        }

        public static int GetDiscountAmount(int subTotal)
        {
            if (CurrentIsBogo)
                return (int)Math.Round(subTotal / 2.0, 0);
            if (CurrentDiscountType == "THRESHOLD" && subTotal >= CurrentMinAmount && CurrentMinAmount > 0)
                return (int)Math.Round(subTotal * (1 - CurrentDiscountRate), 0);
            return 0;
        }

        public static int GetTotal(bool isDelivery)
        {
            int sub = GetSubTotal();
            int discount = GetDiscountAmount(sub);
            int fee = isDelivery ? (sub >= FreeDeliveryMin ? 0 : DeliveryFee) : 0;
            return sub - discount + fee;
        }

        public static void LogoutAdmin()
        {
            IsAdminLoggedIn = false;
            AdminAccount = "";
        }

        public static void ClearMember()
        {
            CurrentMemberID = 0;
            CurrentMemberName = "";
            CurrentMemberPhone = "";
        }
    }



    // ── 購物車項目
    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }  // 單價
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int LineTotal { get { return UnitPrice * Quantity; } }
    }

    public static class GlobalData
    {
        // 1. 全台灣本島縣市清單
        public static List<string> CityList = new List<string>
    {
        "基隆市", "臺北市", "新北市", "桃園市", "新竹市", "新竹縣", "宜蘭縣",
        "苗栗縣", "臺中市", "彰化縣", "南投縣", "雲林縣",
        "嘉義市", "嘉義縣", "臺南市", "高雄市", "屏東縣",
        "花蓮縣", "臺東縣"
    };

        // 2. 全台灣本島行政區對照表 (Dictionary)
        public static Dictionary<string, List<string>> DistrictData = new Dictionary<string, List<string>>
    {
        { "基隆市", new List<string> { "仁愛區", "信義區", "中正區", "中山區", "安樂區", "暖暖區", "七堵區" } },
        { "臺北市", new List<string> { "中正區", "大同區", "中山區", "松山區", "大安區", "萬華區", "信義區", "士林區", "北投區", "內湖區", "南港區", "文山區" } },
        { "新北市", new List<string> { "板橋區", "三重區", "中和區", "永和區", "新莊區", "新店區", "樹林區", "鶯歌區", "三峽區", "淡水區", "汐止區", "瑞芳區", "土城區", "蘆洲區", "五股區", "泰山區", "林口區", "深坑區", "石碇區", "坪林區", "三芝區", "石門區", "八里區", "平溪區", "雙溪區", "貢寮區", "金山區", "萬里區", "烏來區" } },
        { "桃園市", new List<string> { "桃園區", "中壢區", "大溪區", "楊梅區", "蘆竹區", "大園區", "龜山區", "八德區", "龍潭區", "平鎮區", "新屋區", "觀音區", "復興區" } },
        { "新竹市", new List<string> { "東區", "北區", "香山區" } },
        { "新竹縣", new List<string> { "竹北市", "竹東鎮", "新埔鎮", "關西鎮", "湖口鄉", "新豐鄉", "芎林鄉", "橫山鄉", "北埔鄉", "寶山鄉", "峨眉鄉", "尖石鄉", "五峰鄉" } },
        { "宜蘭縣", new List<string> { "宜蘭市", "羅東鎮", "蘇澳鎮", "頭城鎮", "礁溪鄉", "壯圍鄉", "員山鄉", "冬山鄉", "五結鄉", "三星鄉", "大同鄉", "南澳鄉" } },
        { "苗栗縣", new List<string> { "苗栗市", "苑裡鎮", "通霄鎮", "竹南鎮", "頭份市", "後龍鎮", "卓蘭鎮", "大湖鄉", "公館鄉", "銅鑼鄉", "南庄鄉", "頭屋鄉", "造橋鄉", "三義鄉", "西湖鄉", "三灣鄉", "獅潭鄉", "泰安鄉" } },
        { "臺中市", new List<string> { "中區", "東區", "南區", "西區", "北區", "北屯區", "西屯區", "南屯區", "太平區", "大里區", "霧峰區", "烏日區", "豐原區", "后里區", "石岡區", "東勢區", "和平區", "新社區", "潭子區", "大雅區", "神岡區", "大肚區", "沙鹿區", "龍井區", "梧棲區", "清水區", "大甲區", "外埔區", "大安區" } },
        { "彰化縣", new List<string> { "彰化市", "鹿港鎮", "和美鎮", "線西鄉", "伸港鄉", "福興鄉", "秀水鄉", "花壇鄉", "芬園鄉", "員林市", "溪湖鎮", "田中鎮", "大村鄉", "埔鹽鄉", "埔心鄉", "永靖鄉", "社頭鄉", "二水鄉", "北斗鎮", "二林鎮", "田尾鄉", "埤頭鄉", "芳苑鄉", "大城鄉", "竹塘鄉", "溪州鄉" } },
        { "南投縣", new List<string> { "南投市", "埔里鎮", "草屯鎮", "竹山鎮", "集集鎮", "名間鄉", "鹿谷鄉", "中寮鄉", "魚池鄉", "國姓鄉", "水里鄉", "信義鄉", "仁愛鄉" } },
        { "雲林縣", new List<string> { "斗六市", "斗南鎮", "虎尾鎮", "西螺鎮", "土庫鎮", "北港鎮", "古坑鄉", "大埤鄉", "莿桐鄉", "林內鄉", "二崙鄉", "崙背鄉", "麥寮鄉", "東勢鄉", "褒忠鄉", "臺西鄉", "元長鄉", "四湖鄉", "口湖鄉", "水林鄉" } },
        { "嘉義市", new List<string> { "東區", "西區" } },
        { "嘉義縣", new List<string> { "太保市", "朴子市", "布袋鎮", "大林鎮", "民雄鄉", "溪口鄉", "新港鄉", "六腳鄉", "東石鄉", "義竹鄉", "鹿草鄉", "水上鄉", "中埔鄉", "竹崎鄉", "梅山鄉", "番路鄉", "大埔鄉", "阿里山鄉" } },
        { "臺南市", new List<string> { "中西區", "東區", "南區", "北區", "安平區", "安南區", "永康區", "歸仁區", "新化區", "左鎮區", "玉井區", "楠西區", "南化區", "仁德區", "關廟區", "龍崎區", "官田區", "麻豆區", "佳里區", "西港區", "七股區", "將軍區", "學甲區", "北門區", "新營區", "後壁區", "白河區", "東山區", "六甲區", "下營區", "柳營區", "鹽水區", "善化區", "大內區", "山上區", "新市區", "安定區" } },
        { "高雄市", new List<string> { "新興區", "前金區", "苓雅區", "鹽埕區", "鼓山區", "旗津區", "前鎮區", "三民區", "楠梓區", "小港區", "左營區", "仁武區", "大社區", "岡山區", "路竹區", "阿蓮區", "田寮區", "燕巢區", "橋頭區", "梓官區", "彌陀區", "永安區", "湖內區", "鳳山區", "大寮區", "林園區", "鳥松區", "大樹區", "旗山區", "美濃區", "六龜區", "內門區", "杉林區", "甲仙區", "桃源區", "那瑪夏區", "茂林區", "茄萣區" } },
        { "屏東縣", new List<string> { "屏東市", "三地門鄉", "霧臺鄉", "瑪家鄉", "九如鄉", "里港鄉", "高樹鄉", "鹽埔鄉", "長治鄉", "麟洛鄉", "竹田鄉", "內埔鄉", "萬丹鄉", "泰武鄉", "來義鄉", "萬巒鄉", "崁頂鄉", "新埤鄉", "南州鄉", "林邊鄉", "東港鎮", "琉球鄉", "佳冬鄉", "新園鄉", "枋寮鄉", "枋山鄉", "春日鄉", "獅子鄉", "車城鄉", "牡丹鄉", "恆春鎮", "滿州鄉" } },
        { "花蓮縣", new List<string> { "花蓮市", "鳳林鎮", "玉里鎮", "新城鄉", "吉安鄉", "壽豐鄉", "光復鄉", "豐濱鄉", "瑞穗鄉", "富里鄉", "秀林鄉", "萬榮鄉", "卓溪鄉" } },
        { "臺東縣", new List<string> { "臺東市", "成功鎮", "關山鎮", "卑南鄉", "鹿野鄉", "池上鄉", "東河鄉", "長濱鄉", "太麻里鄉", "大武鄉", "綠島鄉", "蘭嶼鄉", "延平鄉", "海端鄉", "達仁鄉", "金峰鄉" } }
    };
    }
}