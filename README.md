<!-- Banner -->

<p align="center">
  <a href="https://www.uit.edu.vn/" title="Trường Đại học Công nghệ Thông tin" style="border: none;">
    <img src="https://i.imgur.com/WmMnSRt.png" alt="Trường Đại học Công nghệ Thông tin | University of Information Technology">
  </a>
</p>

<h1 align="center"><b>LẬP TRÌNH MẠNG CĂN BẢN</b></h>

  

## THÀNH VIÊN NHÓM

| STT    | MSSV          | Họ và Tên              |Chức Vụ    |
| ------ |:-------------:| ----------------------:|----------:
| 1      | 23520858      | Nguyễn Hoàng Lộc       |Nhóm trưởng|
| 2      | 23520738      | Huỳnh Minh Khoa        |Thành viên |

## GIỚI THIỆU MÔN HỌC

* **Tên môn học:** Lập trình mạng căn bản

* **Mã môn học:** NT106

* **Mã lớp:** NT106.P12

* **Năm học:** HK1 (2024 - 2025)

* **Giảng viên**: ThS.Đặng Lê Bảo Chương

  

### MỤC LỤC

    Chương 1: Tổng quan
      1. Giới thiệu đề tài
        1.1 Nội dung chính của đề tài
        1.2 Lý do chọn thực hiện đề tài
        1.3 Sự liên quan giữa đề tài và môn học
      2. Các công nghệ sử sụng
    Chương 2: Triển khai
      1. Chức năng
      2. Giao diện
    Chương 3: Mô hình phân rã chức năng & Network stack
      1. Mô hình phân rã chức năng
      2. Network stack
        a. Network diagram
        b. Cấu trúc gói tin
    Chương 4: Kết luận
    Nguồn tham khảo


### Chương 1: Tổng quan

#### 1. Giới thiệu đề tài

##### 1.1 Nội dung chính đề tài
- Battleships là một trò chơi quen thuộc với nhiều người, đòi hỏi sự chiến đấu chiến thuật quyết liệt từ người chơi. Tuy nhiên, nhóm chúng em nhận thấy rằng trò chơi Battleships truyền thống vẫn còn nhiều hạn chế, đặc biệt là về khả năng kết nối và giao tiếp giữa các người chơi. Nhu cầu giao lưu trong game là điều không thể thiếu. Việc mở rộng hệ thống truyền thông và áp dụng giao thức TCP/IP giúp mạng lưới kết nối ngày càng rộng mở hơn.
##### 1.2 Lý do chọn thực hiện đề tài
- Battleships là trò chơi quen thuộc với nhiều người, có áp dụng nhiều vấn đề liên quan đến lập trình mạng.
##### 1.3 Sự liên quan giữa đề tài và môn học
- Trò chơi áp dụng giao thức TCP/IP.
- Mô hình server, client. 
- Xử lý luồng(threading).
- Sử dụng .NET Framework.

#### 2. Các công nghệ sử dụng
- WinForms:
  - Xây dựng phần Network ở Client và Server.
  - Xây dụng UI ở Client.  
  ![image](https://github.com/user-attachments/assets/f9748cc3-11ff-43f8-9db2-e42ccdb7ef46)
- Google Cloud Platform & Computer Engine:
  - Cung cấp các dịch vụ để chạy Server.  
  ![image](https://github.com/user-attachments/assets/f1973e07-fc40-466b-adda-791e6ed86a5c)

### Chương 2: Triển khai

#### 1. Tính năng

- Đặt tên. 
- Tạo phòng (private hoặc public), tham gia vào phòng bằng ID phòng hoặc tham gia phòng public trong danh sách.
- Triển khai đặt tàu lên lưới. 
- Thực hiện ‘đánh chìm’ tàu của đối phương. 
- Trò chuyện bằng đoạn chat trong game. 
- Hiện ra hình ảnh chiến thắng hoặc thất bại khi kết thúc trò chơi.
 

#### 2. Giao diện
![image](https://github.com/user-attachments/assets/b427332e-03f5-46c4-b523-5ba2e4db9fc1)  
*Hình 1. Giao diện menu chính.*  

![image](https://github.com/user-attachments/assets/8e0c840b-c670-4a6e-80c1-80bde71d6d1e)  
*Hình 2. Giao diện đặt tên.*  

![image](https://github.com/user-attachments/assets/a88f04c2-42eb-4f7b-88ad-e8687aeff973)  
*Hình 3. Giao diện tạo phòng.*  

![image](https://github.com/user-attachments/assets/58ceb6cd-3a07-4c32-b30c-bacd9913b259)  
*Hình 4. Giao diện phòng chờ.*  

![image](https://github.com/user-attachments/assets/b8b1da62-a18c-4d91-ab90-61644d6a64cb)  
*Hình 5. Giao diện đặt tàu.*  

![image](https://github.com/user-attachments/assets/dfa953ac-c999-40b5-882b-742b8cafc165)  
*Hình 6. Giao diện bắn tàu.*  

![image](https://github.com/user-attachments/assets/d3bae5a9-729a-4ecc-bbde-26b9049de52a)
*Hình 7. Giao diện khi người chơi thắng.*  

![image](https://github.com/user-attachments/assets/a536fa72-2a39-4ac5-a101-768512cdbb0a)  
*Hình 8. Giao diện khi người chơi thua cuộc.*  

### Chương 3: Mô hình phân rã chức năng & Network stack

#### 1. Mô hình phân rã chức năng
![image](https://github.com/user-attachments/assets/ba637a8d-e9e5-4d51-8320-dee98a468c83)  
*Hình 9. Mô hình phân rã chức năng.*

#### 2. Network stack
##### a. Network diagram  

![image](https://github.com/user-attachments/assets/fdb625f6-9cc2-4c70-bb90-c3983c067138)
 
*Hình 10. Network diagram*

##### b. Cấu trúc gói tin

![image](https://github.com/user-attachments/assets/ff28cca8-8f0c-488d-8853-c4bfe0eff6a1)  
*Hình 11. Cấu trúc tổng quát gói tin.*

<table border="1" style="border-collapse: collapse; width: 100%; text-align: center;">
    <thead>
        <tr>
            <th>Code</th>
            <th>Cấu trúc</th>
            <th>Client</th>
            <th>Server</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>0</td>
            <td>0|PlayerName|</td>
            <td>Gửi yêu cầu đặt tên</td>
            <td>Kiểm tra tên đã tồn tại chưa, thêm người dùng, trả kết quả.</td>
        </tr>
        <tr>
            <td>1</td>
            <td>1|PlayerName|RoomProperties|</td>
            <td>Gửi yêu cầu tạo phòng (private hoặc public)</td>
            <td>Tạo ID phòng, thêm ID phòng vào danh sách, trả kết quả.</td>
        </tr>
        <tr>
            <td>2</td>
            <td>2|PlayerName|RoomID|</td>
            <td>Gửi thông tin bản đồ đặt thuyền.</td>
            <td>Nhận bản đồ và xác định lượt bắn cho 2 người chơi.</td>
        </tr>
        <tr>
            <td>3</td>
            <td>SendMove: 3|RoomID:PlayerName|x:y|</td>
            <td>Gửi tọa độ điểm bắn trên bản đồ.</td>
            <td>Xác định trúng hoặc trượt và trạng thái các tàu trên bản đồ.</td>
        </tr>
        <tr>
            <td>4</td>
            <td>4|RoomID|</td>
            <td>Gửi tín hiệu bắt đầu đặt thuyền</td>
            <td>Xác định RoomID và cho 2 người chơi vào đặt thuyền.</td>
        </tr>
        <tr>
            <td>5</td>
            <td>5|RoomID|PlayerName|</td>
            <td>Gửi tín hiệu rời phòng</td>
            <td>
                - Nếu đang trong trận: cho đối phương thắng.<br>
                - Nếu đang ở sảnh chờ: cập nhật lại số lượng người chơi trong phòng.
            </td>
        </tr>
        <tr>
            <td>6</td>
            <td>6|RoomID|PlayerName|</td>
            <td>Bắt đầu trò chơi</td>
            <td>Xác định trạng thái đặt thuyền của cả 2 và gửi tín hiệu tiến vào trò chơi.</td>
        </tr>
        <tr>
            <td>8</td>
            <td>8|RoomID|PlayerName|Message</td>
            <td>Gửi tin nhắn</td>
            <td>Nhận tin nhắn và broadcast cho cả phòng.</td>
        </tr>
        <tr>
            <td>9</td>
            <td>9|PlayerName|RoomID|</td>
            <td>Yêu cầu tham gia phòng</td>
            <td>Nhận thông tin, kiểm tra RoomID có tồn tại không và cập nhật số lượng người chơi trong phòng.</td>
        </tr>
        <tr>
            <td>10</td>
            <td>10|PlayerName|</td>
            <td>
                <p>Cập nhật thông tin các phòng cho người chơi mới truy cập.</p>
                <p>Cập nhật lại số lượng người chơi trong các phòng public ở dashboard.</p>
            </td>
            <td>
                <p>Nhận thông tin và broadcast cho các người chơi.</p>
            </td>
        </tr>
    </tbody>
</table>




### Chương 4: Kết luận
-	Thông qua đồ án môn học Lập trình mạng căn bản (NT106) trong học kỳ này, chúng em đã tích lũy được nhiều kiến thức và kinh nghiệm quý báu từ thầy. Chúng em sẽ tiếp tục cố gắng hoàn thiện kỹ năng lập trình mạng cũng như hoàn thiện đồ án của mình.
-	Hướng phát triển kế tiếp cho đồ án: 
    -	Khắc phục và cải thiện các bug phát sinh trong quá trình vận hành.
    - Clean và optimize lại code trên client và server.
    -	Cải thiện giao diện.

>**Lưu ý:** Do bàn cờ và thuyền là những hình ảnh nên các bạn nên đặt tỉ lệ scale screen là **125%** để việc trải nghiệm diễn ra suôn sẻ nhất.

[Video Demo](https://drive.google.com/file/d/1NmYBbWzfpMOJyaStbBQMs_hKbtT32rcA/view?usp=drive_link)

### Nguồn tham khảo
1. [Đồ án NT106 - Lập trình mạng căn bản, Năm học 2023, Trường Đại học Công nghệ thông tin - VNUHCM:](https://onedrive.live.com/?redeem=aHR0cHM6Ly8xZHJ2Lm1zL2YvYy9jM2Q1MjYxY2E3ODMyODI4L0VpZ29nNmNjSnRVZ2dNTWlxUUFBQUFBQmh1N1hUNUthOVVpSUc5cjBaT2k2VXc%5FZT05U2NFUGs&id=C3D5261CA7832828%2143336&cid=C3D5261CA7832828&v=validatepermission)
2. [Computer Engine - Google Cloud Platform](https://cloud.google.com/build/docs/deploying-builds/deploy-compute-engine)
3. [TcpClient Class - WinForms C#](https://learn.microsoft.com/en-us/dotnet/api/system.net.sockets.tcpclient?view=net-9.0)
4. [Create a WinForms App](https://learn.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022)
