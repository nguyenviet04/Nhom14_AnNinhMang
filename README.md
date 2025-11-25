# Giới thiệu

Ứng dụng Windows Forms viết bằng C# minh họa quy trình tạo và kiểm tra chữ ký số dựa trên RSA. Dự án phục vụ bài tập lớn môn An toàn Bảo mật Thông tin, giúp người học quan sát trực quan việc sinh khóa, ký số và xác thực tính toàn vẹn dữ liệu.

---

# Tính năng

- **Sinh khóa RSA:** Tự động sinh cặp số nguyên tố lớn \(P, Q\), tính khóa công khai \((E, N)\) và khóa bí mật \((D, N)\).
- **Ký số văn bản/tệp:** Hỗ trợ ký trên văn bản nhập tay hoặc tệp tin; hiển thị giá trị băm và chữ ký ở dạng thập lục phân.
- **Xác minh chữ ký:** Kiểm tra toàn vẹn và nguồn gốc dữ liệu bằng khóa công khai tương ứng, thông báo kết quả rõ ràng.
- **Lưu/đọc khóa và chữ ký:** Cho phép xuất/nhập khóa và chữ ký từ file để tái sử dụng.

---

# Yêu cầu hệ thống và cài đặt

- **Hệ điều hành:** Windows 10 hoặc Windows 11.
- **Nền tảng:** .NET Framework 4.7.2 trở lên (hoặc .NET 6.0 tùy phiên bản dự án).
- **Công cụ:** Visual Studio 2022.

## Cài đặt

1. **Sao chép kho chứa:**
   ```bash
   git clone https://github.com/nguyenvviet04/Nhom14_AnNinhMang.git
   ```
2. **Mở solution:**
   - **AnNinhMang.sln** trong Visual Studio 2022.
3. **Biên dịch và chạy:**
   - Nhấn **F5** hoặc chọn **Start** để chạy ứng dụng.

---

# Cách sử dụng

- **Sinh khóa:** Mở ứng dụng, vào mục sinh khóa để tạo cặp Public/Private Key và lưu lại nếu cần.
- **Ký dữ liệu:** Nhập văn bản hoặc chọn tệp, chọn thuật toán băm mặc định, dùng khóa bí mật để tạo chữ ký số.
- **Xác minh:** Tải văn bản/tệp gốc, chữ ký và khóa công khai; chạy xác minh để kiểm tra tính toàn vẹn.
- **Lưu trữ:** Xuất/nhập khóa và chữ ký qua các nút lưu/mở file trong ứng dụng.

---

# Cấu trúc dự án

- **BigIntegerExtensions.cs:** Tiện ích mở rộng cho BigInteger, hỗ trợ tính toán số học lớn phục vụ RSA.
- **FileHandler.cs:** Đọc/ghi tệp văn bản, khóa và chữ ký; quản lý I/O an toàn.
- **RSACore.cs:** Lõi thuật toán RSA (sinh khóa, mã hóa/giải mã, ký/xác minh).
- **Form1.cs / Form1.Designer.cs / Form1.resx:** Giao diện Windows Forms và logic tương tác người dùng.
- **Program.cs:** Điểm vào chương trình, khởi tạo ứng dụng.
- **.gitignore:** Quy định các tệp/thư mục bỏ qua khi theo dõi bằng Git.

---

# Hình ảnh minh họa

<img width="862" height="606" alt="image" src="https://github.com/user-attachments/assets/4c2c0679-ce30-4166-adcb-99fc0822f4c9" />

---

# Liên hệ

- **Tên:** Nguyễn Quốc Việt  
- **Email:** vietsky12092004@gmail.com

Bạn muốn mình thêm mục Giấy phép (License) hoặc hướng dẫn đóng góp (Contributing) không?
