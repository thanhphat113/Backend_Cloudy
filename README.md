## Backend_Cloudy
Mạng xã hội này cung cấp các tính năng cơ bản như đăng ký, đăng nhập, quản lý hồ sơ người dùng, kết bạn, chia sẻ bài viết và tương tác với bài viết của bạn bè. API cho phép người dùng tương tác với nền tảng mạng xã hội thông qua các endpoint RESTful.

## Mục Lục
1. [Giới thiệu](#giới-thiệu)
2. [Cài Đặt](#cài-đặt)
3. [Kiểm Tra](#kiểm-tra)
4. [Giới Thiệu Về Tác Giả](#giới-thiệu-về-tác-giả)

## Giới Thiệu

**Social Network API** là một hệ thống mạng xã hội cho phép người dùng đăng ký, đăng nhập, chia sẻ bài viết, kết bạn và tương tác với các bài viết của bạn bè. Mục tiêu của API này là xây dựng một nền tảng mạng xã hội đơn giản nhưng đầy đủ các chức năng cơ bản để kết nối mọi người. Dự án được phát triển bằng **ASP.NET Core** và sử dụng **MySQL** làm cơ sở dữ liệu.

**Frontend_Cloudy**: [https://github.com/thanhphat113/Frontend_Cloudy](https://github.com/thanhphat113/Frontend_Cloudy) 

## Cài Đặt

Để cài đặt và chạy dự án này, bạn cần thực hiện các bước sau:

### 1. Cài Đặt Prerequisites

- .NET Core SDK
- MySQL (hoặc MariaDB)
  
### 2. Cài Đặt Dự Án

```bash
git clone https://github.com/thanhphat113/Backend_Cloudy.git
cd Backend_Cloudy
```

### 3. Sau đó hãy cài đặt các phụ thuộc

```bash
dotnet restore
dotnet ef update database
```

### 3. Chạy dự án

```bash
dotnet run
```
API của bạn sẽ chạy trên cổng mặc định, ví dụ <code>http://localhost:5164</code>

## Kiểm tra
### 1. Tài Khoản Demo

Chúng tôi cung cấp tài khoản demo để bạn có thể thử nghiệm API mà không cần phải đăng ký mới. Sử dụng thông tin đăng nhập sau để truy cập API:

### 2. Thông Tin Tài Khoản Demo

- **Email**: 15@gmail.com
- **Mật khẩu**: 123


## Giới Thiệu Về Tác Giả

### 1. **Lý Thanh Phát**

- **Kỹ năng**: 
  - C# & ASP.NET Core
  - MySQL, SignalR
  - WebRTC
- **Mô tả**: chịu trách nhiệm chính trong việc phát triển dự án, bao gồm việc tạo và quản lý cơ sở dữ liệu, dựng cấu trúc dự án, xác thực người dùng, cũng như xử lý các chức năng chính của hệ thống.

### 2. **Minh Điền**
- **Kỹ năng**:
  - C# & ASP.NET Core
- **Mô tả**: phụ trách xử lý API về thông tin cá nhân.



