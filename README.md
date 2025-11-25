#Giới thiệu (Introduction)
Dự án này là một ứng dụng Windows Forms được xây dựng bằng ngôn ngữ C#, minh họa quy trình tạo và kiểm tra chữ ký số sử dụng thuật toán mã hóa bất đối xứng RSA.
Ứng dụng được phát triển như một phần của bài tập lớn môn An toàn Bảo mật Thông tin, nhằm mục đích:
  - Minh họa trực quan quá trình sinh khóa (Public Key/Private Key).
  - Thực hiện ký số (Hashing + Encryption) lên văn bản hoặc tệp tin.
  - Xác thực tính toàn vẹn và nguồn gốc của dữ liệu (Verification).
#Tính năng Chính (Features)
  Sinh khóa RSA	- Tự động sinh cặp số nguyên tố P, Q lớn và tính toán khóa công khai (E, N), khóa bí mật (D, N).
  Tạo chữ ký (Signing) - Hỗ trợ ký trên văn bản nhập tay hoặc tệp tin (.txt,.doc). Hiển thị mã Hash và Chữ ký số thập lục phân.
  Kiểm tra chữ ký (Verifying) -	Xác thực văn bản/tệp tin với chữ ký và khóa công khai tương ứng. Thông báo chính xác tính toàn vẹn.
  Lưu trữ -	Cho phép lưu khóa và chữ ký ra file để tái sử dụng.
#Yêu cầu Hệ thống & Cài đặt (Installation)
Để chạy mã nguồn hoặc tệp thực thi, máy tính cần đáp ứng:
  - Hệ điều hành: Windows 10/11.
  - Môi trường:.NET Framework 4.7.2 trở lên (hoặc.NET 6.0 tùy phiên bản bạn dùng).
  - Công cụ phát triển: Visual Studio 2022.
Các bước cài đặt:
  - Sao chép kho chứa về máy:bash git clone 
  - Mở tệp ElectronicSignatureRSA.sln bằng Visual Studio 2022.
  - Nhấn F5 hoặc chọn Start để biên dịch và chạy chương trình.
#Hình ảnh Minh họa
<img width="862" height="606" alt="image" src="https://github.com/user-attachments/assets/4c2c0679-ce30-4166-adcb-99fc0822f4c9" />
#Liên hệ
Mọi liên hệ xin đến Nguyễn Quốc Việt - vietsky12092004@gmail.com
