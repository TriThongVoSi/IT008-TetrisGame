# ĐỒ ÁN LẬP TRÌNH TRỰC QUAN

# Tetris Game - Phần mềm Trò chơi Xếp Gạch

## Giới thiệu

Đây là phần mềm trò chơi Tetris (Xếp gạch) được phát triển bằng ngôn ngữ C# với giao diện WPF hiện đại, hỗ trợ nhiều tính năng hấp dẫn như:
- Đăng ký, đăng nhập người chơi
- Lưu trữ điểm số, cấp độ, thời gian chơi tốt nhất
- Bảng xếp hạng (Leaderboard) các người chơi xuất sắc
- Hệ thống âm thanh sống động (nhạc nền, hiệu ứng)
- Hỗ trợ tạm dừng, tiếp tục, hướng dẫn chơi
- Giao diện đẹp, dễ sử dụng, trải nghiệm mượt mà

## Giao diện & Chức năng chính

- **Màn hình chính (Main/InGame):** Chọn bắt đầu chơi, xem bảng xếp hạng, hướng dẫn, thoát game.
- **Đăng nhập/Đăng ký (Player/Register):** Người chơi có thể đăng nhập hoặc tạo tài khoản mới, chọn giới tính.
- **Chơi game:** Giao diện chơi Tetris cổ điển, có hiển thị điểm, cấp độ, khối tiếp theo, khối đang giữ, tên người chơi.
- **Bảng xếp hạng (Leaderboard):** Hiển thị top các người chơi có điểm số cao nhất.
- **Hướng dẫn (Instruction):** Hướng dẫn cách chơi, điều khiển.
- **Tạm dừng (Pause):** Có thể tạm dừng và quay lại màn hình chính.

## Yêu cầu hệ thống

- **Hệ điều hành:** Windows 10 trở lên
- **.NET SDK:** .NET 8.0 (hoặc mới hơn) có hỗ trợ WPF
- **SQL Server:** Để lưu trữ thông tin người chơi, điểm số (có file script tạo DB đi kèm)

## Hướng dẫn cài đặt & chạy

### 1. Cài đặt môi trường

- Cài đặt [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (chọn bản có WPF)
- Cài đặt SQL Server (Express hoặc bản đầy đủ đều được)

### 2. Tạo Database

- Mở SQL Server Management Studio (SSMS) hoặc công cụ quản lý SQL khác
- Chạy file `Tetris_Game/DBTetris.sql` để tạo database `PlayerManagement` và các bảng cần thiết

### 3. Cấu hình kết nối Database

- Mặc định, chuỗi kết nối trong `Tetris_Game/App.config` là:
  ```
  Server=QUOCTHONG;Database=PlayerManagement;User Id=Tetris;Password=123456789;TrustServerCertificate=True;
  ```
- Nếu bạn dùng server khác, hãy sửa lại `Server=...`, `User Id=...`, `Password=...` cho phù hợp với SQL Server của bạn.

### 4. Build & chạy game

- Mở solution `Tetris_Game.sln` bằng Visual Studio 2022 trở lên
- Chọn project `Tetris_Game` và build (Ctrl+Shift+B)
- Nhấn F5 hoặc chọn "Start" để chạy game

### 5. Thư viện/phụ thuộc

- Dự án sử dụng các package NuGet:
  - `Microsoft.Data.SqlClient` (kết nối SQL Server)
  - `NAudio` (xử lý âm thanh)

Các package này sẽ được tự động cài khi build project.

## Điều khiển cơ bản

- **Di chuyển khối:** ← → ↓
- **Xoay khối:** Phím lên (↑)
- **Giữ khối:** Phím C
- **Tạm dừng:** Phím P hoặc nút trên giao diện

---
Tác giả: [Trương Quốc Thông - Trần Quốc Thịnh - Võ Sĩ Trí Thông] 
---
Nếu cần file .docx báo cáo đồ án liên hệ qua gmail vosithongtri@gmail.com (hạt dẻ 150 cành cả nhóm)
