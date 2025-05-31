Một số luật khi làm bài:
1. Đặt tên nhánh theo mục mình làm.
2. Khi làm xong nhắn nhóm để có thể pull request là gộp vào nhánh main.
3. Sau khi pull request xong, pull code về để có cập nhật mới nhất.
4. Clone nhánh main về và làm trên nhánh đó xong rồi push lên nhánh của mình trên github.
5. Nhớ code đẹp và gọn nha (Không có cái này check điều kiện cái kia không, không để nguyên lỗi của Chat nha - /*.....Error.....*/ :)))))))
6. Khi code xong nhớ chỉnh sửa file README trên nhánh mình để mọi người dễ hiểu nha.
7. Có gì không ổn nhớ nhắn Quân nha.

Quân:
1. Quân chỉnh lại CSDL nữa nha thiếu N trước chuỗi có dấu.
2. Quân đã sửa xong YC1/Câu 2 rồi nha.
3. Nhớ chỉnh lại Service name để có thể kết nối với CSDL của mình nha.
4. Nhớ chạy lại database và data nha.

Phú:
1. chạy scripts trong YC1/Câu 3 dể test chức năng sinh viên, giảng viên theo yêu cầu bài
2. Đăng nhập với tài khoản của Nhân viên Phòng CTSV để test chức năng thêm, xóa, sửa. VD: NV7663. 
3. 
- Các UI chưa xong:
+ -- Người dùng có VAITRO là “TRGĐV” có quyền xem các dòng dữ liệu liên quan đến các nhân viên thuộc đơn vị mình làm trưởng, trừ các thuộc tính LUONG và PHUCAP.
+ Người dùng có vai trò “TRGĐV” có quyền xem các dòng phân công giảng dạy của các giảng viên thuộc đơn vị mình làm trưởng.
+ YC1: Câu 4 (chưa làm phần UI cho câu này nhưng có lẽ sẽ tái sử dụng được 1 vài màn hình trước đó)
Lưu ý: Phú chỉ làm được phần UI nên các câu truy vấn (query) Phú làm theo cảm tính (kiểu ra kết quả là được) nên mng cần sửa lại cho đúng theo các câu mng làm.

Phúc
* Bắt buộc phải chạy câu 1 yc1 rồi mới chạy code.


Tâm: Một vài lưu ý khi sao lưu và khôi phục
1. thay thế <service name> hay free ở các đường dẫn kết nối tới oracle ở các file bash và sql trong yêu cầu 4.
2. Tâm viết trên mac nên có thể bị sót vài chỗ mà k chạy đưuọc trên win, nên mọi người chạy thử rồi báo Tâm xem nhé.
3. Đối với tính năng tự động sao lưu, mọi người có thể thay đổi thời gian ở byhour(Lưu ý: thời gian hệ thống chậm 7 tiếng so với thời gian thực) để test liệu job có được thực hiện hay không.