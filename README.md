<<<<<<< HEAD
# TechStore Management System - Hệ thống Quản lý Cửa hàng Điện tử

Dự án xây dựng ứng dụng máy tính (Desktop Application) toàn diện hỗ trợ quản lý chuỗi quy trình kinh doanh, vận hành kho, bán hàng và chăm sóc khách hàng chuyên biệt cho các cửa hàng thiết bị công nghệ điện tử. Hệ thống ưu tiên tối ưu hóa hiệu năng, độ chính xác cao và trải nghiệm thao tác thuận tiện cho người sử dụng.

---

## 🛠️ Công nghệ Sử dụng & Môi trường Phát triển

* **Nền tảng & Ngôn ngữ:** Windows Forms (WinForms) dựa trên nền tảng .NET 9.0 và ngôn ngữ C#.
* **Môi trường Phát triển (IDE):** JetBrains Rider.
* **Cơ sở Dữ liệu (Database):** MariaDB kết hợp với Micro-ORM **Dapper** gọn nhẹ, tối ưu hóa tốc độ truy vấn data.
* **Kiến trúc Thiết kế:** Mô hình Kiến trúc 3 lớp phân tách rõ ràng trách nhiệm (Separation of Concerns) bao gồm: GUI - BUS - DAL kết hợp vật chứa DTO.

---

## 📐 Kiến trúc Hệ thống (3-Layer Architecture)

Dự án được phân bổ mô-đun hóa thành 4 cụm thư mục/dự án thành phần nhằm bảo trì và mở rộng mã nguồn dễ dàng:
1. **GUI Layer (Presentation):** Lớp giao diện người dùng hiển thị các biểu mẫu, tiếp nhận sự kiện click/gõ và phản hồi kết quả trực quan.
2. **BUS Layer (Business Logic):** Khối đầu não xử lý toàn bộ các quy tắc nghiệp vụ, ràng buộc logic, tính toán dòng tiền, mã hóa băm mật khẩu bảo mật và điều hướng dữ liệu.
3. **DAL Layer (Data Access):** Lớp tương tác tầng dữ liệu vật lý, quản lý trạng thái đóng/mở kết nối thông qua `DatabaseHelper` và truy vấn tự động mapping dữ liệu bằng Dapper.
4. **DTO Layer (Data Transfer Object):** Định nghĩa các lớp thực thể (Entities/Models) đại diện cho các bảng dữ liệu, đóng vai trò làm vật chứa trung chuyển thông tin xuyên suốt giữa các tầng kiến trúc.

---

## ✨ Các Tính năng Nghiệp vụ Cốt lõi

Hệ thống đáp ứng trọn vẹn chu trình vận hành thực tế của một trung tâm bán lẻ thiết bị công nghệ điện tử lớn:

### 1. Nghiệp vụ Nhập hàng & Quản lý Kho (Inbound & Inventory)
* **Phân loại hàng hóa thông minh:** Tách biệt rõ ràng phương thức quản lý giữa hàng theo Lô/Số lượng (Phụ kiện, cáp sạc) và hàng quản lý đích danh theo ID định danh duy nhất (Serial/IMEI của Laptop, Điện thoại, CPU).
* **Ràng buộc quy trình chặt chẽ:** Khi nhập thiết bị có ID, nhân viên bắt buộc phải quét mã vạch hoặc nhập đủ số lượng mã định danh Serial tương ứng.
* **Theo dõi vòng đời sản phẩm:** Quản lý cập nhật liên tục trạng thái thiết bị: *Trong kho*, *Đã bán*, *Đang bảo hành*, *Lỗi*.

### 2. Nghiệp vụ Bán hàng tốc độ cao (Sales / POS)
* **Tối ưu thao tác:** Giao diện quầy thu ngân ưu tiên tốc độ, hỗ trợ thực hiện hóa đơn nhanh hoàn toàn bằng phím tắt và máy quét vạch.
* **Kiểm tra thời gian thực (Real-time):** Hệ thống tự động truy vấn DB để xác thực trạng thái máy "Trong kho" trước khi cho phép thanh toán, ngăn ngừa xuất nhầm mã Serial.
* **Quản lý thông tin & Tích điểm:** Liên kết hóa đơn với số điện thoại khách hàng phục vụ tích lũy điểm thưởng và truy xuất bảo hành.

### 3. Nghiệp vụ Tiếp nhận Bảo hành & Đổi trả (Warranty & Returns)
* **Tra cứu thần tốc:** Chỉ cần nhập SĐT khách hàng hoặc quét mã Serial máy, hệ thống tự động trả về toàn bộ thông tin ngày mua, nhân viên xử lý, hạn bảo hành và NCC gốc.
* **Theo dõi quy trình (Work-flow):** Ghi nhận phiếu nhận máy lỗi và cập nhật trạng thái xử lý minh bạch (*Đang kiểm tra -> Đã gửi hãng -> Đã sửa xong -> Đã trả khách*).

### 4. Quản lý Ca làm việc & Kiểm soát Dòng tiền
* **Minh bạch tài chính:** Bắt buộc nhân viên khai báo số tiền mặt có sẵn đầu ca và đối chiếu kiểm đếm tiền mặt thực tế cuối ca để ghi nhận chênh lệch dòng tiền.
* **Báo cáo lợi nhuận chính xác:** Tự động tính toán Lợi nhuận gộp bằng thuật toán Nhập trước xuất trước (FIFO) hoặc Đích danh dựa theo Serial.

---

## 🖥️ Danh sách các Giao diện Hệ thống (GUI)

Hệ thống bao gồm 15 màn hình chức năng điều phối dòng việc chặt chẽ:

| STT | Tên Form (C#) | Chức năng chi tiết | Phân quyền truy cập |
| :--- | :--- | :--- | :--- |
| 1 | **FormLogin** | Xác thực tài khoản người dùng, phân quyền hệ thống. | Tất cả |
| 2 | **FormDashboard** | Giao diện trang chủ (MDI Container) điều hướng hệ thống. | Tất cả |
| 3 | **FormSell** | Giao diện POS bán hàng, quét ID, tính tiền và in hóa đơn. | Thu ngân, Quản lý |
| 4 | **FormManageShift** | Khai báo đầu ca, kiểm chốt tiền mặt bàn giao ca. | Thu ngân, Quản lý |
| 5 | **FormGuest** | Quản lý tệp khách hàng, phân hạng thành viên VIP, tích điểm. | Thu ngân, Quản lý |
| 6 | **FormTradeIn** | Tiếp nhận thu cũ đổi mới, định giá thu mua máy lỗi/cũ. | Kỹ thuật, Quản lý |
| 7 | **FormGuarantee** | Tra cứu lịch sử mua hàng, tiếp nhận bảo hành thiết bị. | Kỹ thuật, Quản lý |
| 8 | **FormManageProduct**| Thêm/Sửa/Xóa thông tin cấu hình, danh mục, giá gốc sản phẩm.| Kho, Quản lý |
| 9 | **FormIntoWarehouse**| Tạo phiếu nhập kho từ nhà cung cấp, tít mã ID sản phẩm vào kho.| Kho, Quản lý |
| 10 | **FormCheckInventory**| Lập phiếu kiểm kê, đối chiếu số lượng thực tế với phần mềm.| Kho, Quản lý |
| 11 | **FormPromotion** | Thiết lập chiến dịch khuyến mãi, mã Voucher, cấu hình giảm giá.| Quản lý |
| 12 | **FormSupplier** | Lưu trữ danh bạ nhà cung cấp, theo dõi công nợ nhập hàng.| Quản lý |
| 13 | **FormStaff** | Quản lý hồ sơ nhân viên, reset mật khẩu, theo dõi doanh số.| Quản lý |
| 14 | **FormReport** | Biểu đồ doanh thu, thống kê hàng tồn, phân tích lợi nhuận.| Quản lý |
| 15 | **FormSetting** | Cấu hình máy in hóa đơn, chuỗi kết nối máy chủ dữ liệu.| Admin (IT) |

---

## 🗄️ Cấu trúc Cơ sở Dữ liệu (MariaDB Relational Schema)

Hệ thống lưu trữ cấu trúc liên kết chuẩn hóa dữ liệu thông qua 14 bảng quan hệ:

1. **Roles:** Lưu danh mục vai trò phân quyền người dùng (`Admin`, `QuanLy`, `ThuNgan`...).
2. **Users:** Thông tin tài khoản nhân sự và liên kết quyền hạn `RoleID`.
3. **Customers:** Dữ liệu khách hàng, số điện thoại định danh, phân hạng loại và điểm số.
4. **Suppliers:** Danh sách nhà cung cấp và số dư công nợ lũy kế.
5. **ProductCategories:** Danh mục phân loại các nhóm hàng hóa.
6. **Products:** Định nghĩa thông số gốc của mặt hàng (Tên, Mã vạch, loại hàng có Serial hay không).
7. **ProductItems:** Quản lý thực tế từng máy đích danh trong kho dựa theo số Serial/IMEI cụ thể.
8. **InboundReceipts:** Hóa đơn chứng từ gốc mỗi đợt nhập hàng từ phía đối tác.
9. **InboundDetails:** Chi tiết danh sách số lượng, đơn giá nhập của từng sản phẩm trong phiếu nhập.
10. **SalesInvoices:** Hóa đơn bán lẻ xuất cho khách hàng tại quầy.
11. **SalesDetails:** Chi tiết các mặt hàng hoặc mã Serial đích danh xuất bán trong hóa đơn.
12. **Shifts:** Nhật ký theo dõi ca làm việc, dòng tiền mặt bàn giao khớp ca.
13. **WarrantyClaims:** Hồ sơ lịch sử các ca tiếp nhận sửa chữa bảo hành sản phẩm lỗi.
14. **Promotions:** Lưu trữ các sự kiện giảm giá, thời hạn áp dụng của các chiến dịch ưu đãi.

---

## 🚀 Hướng dẫn Cài đặt & Khởi chạy Dự án

Để chạy ứng dụng ở môi trường máy cục bộ (Local), vui lòng làm theo các bước sau:

### 1. Chuẩn bị Cơ sở Dữ liệu
1. Đảm bảo máy tính của bạn đã cài đặt dịch vụ **MariaDB Server** (Port mặc định: `3306`).
2. Sử dụng một công cụ quản lý cơ sở dữ liệu (Database Client) hoặc dùng trực tiếp tab **Database** tích hợp trong Rider để kết nối vào MariaDB.
3. Tạo một cơ sở dữ liệu trống tên là: `techstore`.
4. Mở cửa sổ **Query Console**, dán toàn bộ mã kịch bản SQL khởi tạo bảng cùng dữ liệu mẫu hệ thống và thực thi (`Execute`).

### 2. Cấu hình Ứng dụng trong JetBrains Rider
1. Tải dự án này về máy tính và mở bằng **JetBrains Rider**.
2. Định vị file `DatabaseHelper.cs` nằm bên trong thư mục dự án lớp **`DAL`**.
3. Cập nhật lại thuộc tính chuỗi cấu hình `ConnectionString` sao cho khớp thông tin tài khoản truy cập cơ sở dữ liệu cục bộ của bạn:
   ```csharp
   private static readonly string ConnectionString = "Server=localhost;Port=3306;Database=techstore;Uid=Tên_User;Pwd=Mật_Khẩu_Của_Bạn;Charset=utf8mb4;";
=======
# Desktop-application-development---Winforms
Đây là Dự án môn học Phảt triển Ứng dụng Desktop. 
>>>>>>> 1056ad97bce0c4b8310e1d1ced8d95200e3b5090
