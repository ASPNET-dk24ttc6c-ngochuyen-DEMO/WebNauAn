# 🍳 Web Dạy Nấu Ăn
> Nền tảng chia sẻ công thức nấu ăn, mẹo nhà bếp và kết nối những người yêu ẩm thực.
---
## 📌 Thông tin chung
*   **Môn học: Chuyên đề ASP.NET**
*   **Sinh viên thực hiện: NGUYỄN THỊ NGỌC HUYỀN - 170124673**
*   **Giảng viên hướng dẫn: TS. ĐOÀN PHƯỚC MIỀN**
*   **Demo Link: https://localhost:44386**
*   **Email: pehuyen170295@gmail.com**
*   **Số điện thoại: 0962873812**
## 📌1. Giới thiệu đề tài
* **Đây là đồ án Xây dựng website chia sẻ công thức nấu ăn sử dụng ASP.NET Web Form kết hợp với Entity Framework Core và SQL Server.**
* **Hệ thống được xây dựng nhằm hỗ trợ khách hàng tìm kiếm, xem thông tin từng món ăn nhanh chóng, Admin quản lý món ăn (thêm, sửa, xóa món).**

*- **Đề tài hướng đến việc áp dụng các kiến thức đã học về:**

* **Lập trình web với ASP.NET Web form, Kết nối và thao tác cơ sở dữ liệu bằng Entity Framework Core.**
* **Thiết kế giao diện website dạy công thức nấu ăn, xây dựng chức năng tìm kiếm, chọn các món hiển thị trên thanh men dễ dàng.**
* **Phân quyền giữa người dùng và Admin.**

## 📌2.Mục tiêu của đề tài
* **Xây dựng website đơn giản**
* **Hiển thị công thức nấu ăn**
* **Lưu trữ dữ liệu bằng SQL Server**
## 📌3.Công nghệ sử dụng
* **Ngôn ngữ lập trình: C#**
* **Framework: ASP.NET Web form.**
* **Cơ sở dữ liệu: SQL Server.**
* **ORM: Entity Framework Core.**
* **Front-end: HTML, CSS, Bootstrap, Razor View Engine.**
* **IDE: Visual Studio 2022.**
## 📌4.Chức năng chính của website
## 4.1 Người dùng
* **Xem danh sách các món ăn**
* **Xem chi tiết từng món ăn**
* **Tìm kiếm món ăn theo tên**
## 4.2 Admin
* **Đăng nhập vào trang quản trị**
* **Xem tổng quan hệ thống**
* **Quản lý món: Sửa/Xóa món**
* **Thêm món mới**
## 4.3 Hệ thống
* **Lấy dữ liệu món từ cơ sở dữ liệu**
* **Hiển thị món ăn đầy đủ theo dữ liệu Sql server**
* **Phân quyền tài khoản giữa người dùng và Admin**
## 5. Cấu trúc dữ liệu chính
* **Hệ thống sử dụng các bảng chính sau:**
* **Admin: Thông tin người đăng nhập gồm tên admin và mật khẩu**
* **Ví dụ: tên đăng nhập :admin ,mk:123**
* **Category: lưu danh mục sản phẩm**
* **Ví dụ: món nuocs, món chiên, món xào, món lẩu ,...**
* **Default: Trang chính hiển thị danh sách các món ăn**
* **Detail: Hiển thị chi tiết món ăn**
* **Gdien.Master: Hiển thị trang web và cài đặt**
* **Logout: Cho phép thoát khỏi trang quản trị**
* **Login: Cho phép đăng nhập vào trang quản trị**
* **ManageRecipe: Cho phép chỉnh sửa thông tin món**
## 6. Giao diện và hoạt động của website
* **Website được thiết kế theo mô hình dạy nấu ăn theo món.**
* **Trang chủ hiển thị danh sách món ăn lấy từ cơ sở dữ liệu. Người dùng có thể:**
* **bấm vào các mục món ăn cần xem**
* **bấm vào thanh tìm kiếm để tìm kiếm sản phẩm**
* **bấm vào xem chi tiết từng món ăn**
* **Admin đăng nhập bằng tài khoản có quyền quản trị để truy cập vào hệ thống trang web. Tại đây, admin có thể:**
* **xem tổng quan hệ thống**
* **quản lý danh sách món**
* **thêm, sửa, xóa món**
## 7. Cấu trúc thư mục repository

│── WebNauAn/README.md
├── src/
│       ├── Properties/
│       ├── References/
│       ├── Admin/
│       ├── Category/
│       ├── Default/
│       ├── Detail/
│       ├── Gdien/
│       ├── Logout/
│       ├── Login/
│       ├── ManageRecipe/
│       ├── packages.config
│       ├── web.config
├── setup/
│   ├──Category.sql
│   ├── Recipes.sql
│   ├── User.sql
├── progress-report/
│   ├── progress-week1-4
├── thesis/
│   ├── doc/
