# FarmOrder 小農蔬菜直送 🌿🛒

> **「不必特地跑市場，只需打開系統，輕鬆收單，讓每份新鮮直達餐桌。」**
> 專為小農、工作室、社區團購設計的輕量級收單整合系統，從訂購到出貨，一站管理。

![Project Stage](https://img.shields.io/badge/Stage-Desktop_Application-green?style=flat-square)
![C#](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/Framework-.NET_4.8-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/Database-SQL_Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)

「FarmOrder」是一套以 **C# Windows Forms** 搭配 **SQL Server** 開發的桌面型團購收單系統。系統定位不限農產品，適用於小農直賣、手作工作室、社區團購等各類收單情境，涵蓋線上訂購、會員管理、後台訂單查詢與彈性折扣設定，並採用**快照設計**保護歷史訂單資料完整性。

---

## ✨ 系統亮點與核心特色

- **雙身分登入系統：**
  - RadioButton 切換會員／管理員登入，COLLATE 語法確保帳號密碼大小寫敏感比對。

- **購物車跨 Form 共用設計：**
  - 以靜態類別 `GlobalVar` 作為共用資料層，`Dictionary<int, CartItem>` 儲存購物車，`ContainsKey` 判斷累加或新增，全程不重複連線資料庫。

- **快照設計保護歷史訂單：**
  - 下單時將產品名稱與單價另存於 `OrderDetails`，產品改價或下架後歷史訂單完全不受影響，符合電商訂單管理的業界標準。

- **彈性折扣方案：**
  - 支援消費門檻折扣與買一送一兩種模式，折扣資料動態從資料庫撈取，新增折扣不需改程式碼。

- **Tooltip 效能優化：**
  - 滑鼠移過產品時即時顯示產品資訊，改版前每次移動都連一次資料庫，優化後直接讀取記憶體中的 List，速度大幅提升。

- **權限分級系統：**
  - 數字區間設計：1-10 管理員、11-20 老闆、21-30 店員、31-40 會員、0 訪客，未來新增角色不需改程式碼。

---

## 🛠️ 技術棧

- **開發語言：** C# / .NET Framework 4.8
- **UI 框架：** Windows Forms
- **資料庫：** SQL Server / ADO.NET
- **開發工具：** Visual Studio 2022

---

## 📂 系統架構

### 客戶端

| Form | 功能 |
|---|---|
| frmOrder | 產品瀏覽、分類篩選、關鍵字搜尋、購物車即時預覽 |
| frmLogin | 會員／管理員雙身分登入、60秒逾時計時器 |
| frmCart | 購物車確認、會員／訪客結帳、宅配／現場取貨切換 |
| frmRegister | 新會員註冊，完成後自動登入並帶入結帳資料 |

### 管理後台

| Form | 功能 |
|---|---|
| frmBossMenu | 後台主選單，依 RoleLevel 顯示可用功能 |
| frmOrderQuery | 多條件訂單查詢、狀態更新、取消訂單 |
| frmProduct | 產品上下架管理、圖片更換 |
| frmDiscount | 折扣方案新增／修改／停用 |
| frmMember | 會員管理（開發中）|
| frmReport | 報表統計（開發中）|

---

## 🗄️ 資料庫設計（FarmOrderDB）

共 7 張 Table，涵蓋會員、產品、訂單、折扣與宅配資訊：

| Table | 說明 |
|---|---|
| Members | 會員資料，Phone 作為登入帳號，含 RoleLevel 權限欄位 |
| Admins | 後台管理員，獨立 Table 只負責登入驗證，不與業務 Table 關聯 |
| Products | 產品資料，含 CategoryName 分類、IsOnShelf 上下架、SortOrder 排序 |
| Discounts | 折扣方案，支援消費門檻折扣與買一送一兩種模式 |
| Orders | 訂單主檔，MemberID 可 NULL 支援訪客結帳，IsGuestOrder 區分身分 |
| OrderDetails | 訂單明細，快照設計另存 ProductName、UnitPrice，不依賴 JOIN Products |
| DeliveryInfo | 宅配資訊，只有選宅配的訂單才寫入，現場取貨無此記錄 |

**設計決策：**
- `OrderDetails` 快照設計保護歷史訂單，產品改價或刪除後舊訂單完全不受影響
- `SortOrder` 欄位讓管理員自由控制產品與折扣的顯示順序，不受 PK 自動遞增限制
- 權限數字區間設計：1-10 管理員、11-20 老闆、21-30 店員、31-40 會員、0 訪客
