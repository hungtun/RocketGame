## RocketGame — Mini Project Unity 3D

### TL;DR

- Một game điều khiển tên lửa đơn giản, tập trung vào cảm giác điều khiển, âm thanh – hiệu ứng, và vòng lặp chơi ngắn gọn. Dự án nhỏ nhưng được tổ chức rõ ràng, dễ đọc, dễ mở rộng, phù hợp để nhà tuyển dụng đánh giá nhanh kỹ năng Unity/C# và cách làm việc của tôi.

## Giới thiệu

RocketGame là một dự án Unity 3D nhỏ, nơi người chơi điều khiển một chiếc tên lửa hạ cánh an toàn lên bệ đáp. Trò chơi nhấn mạnh vào:

- Điều khiển mượt mà (lực đẩy/thrust và xoay/rotate)
- Phản hồi âm thanh – hình ảnh tức thời
- Vòng lặp thử–sai nhanh giúp người chơi “cảm” được quán tính

Mục tiêu của dự án là thể hiện khả năng:

- Viết code C# sạch, tách trách nhiệm rõ ràng
- Tổ chức asset/hệ thống scene hợp lý
- Tư duy sản phẩm: hoàn thiện trải nghiệm nhỏ nhưng chỉn chu

## Điểm nổi bật kỹ thuật

- Tách logic theo component rõ ràng: `Movement.cs` chịu trách nhiệm điều khiển, `CollisionHandler.cs` chịu trách nhiệm va chạm/trạng thái level
- Sử dụng `Rigidbody` để có quán tính vật lý tự nhiên, clamp input để điều khiển ổn định
- Hệ thống âm thanh và particle gọn nhẹ: boost, thắng/thua, hiệu ứng lửa/khói
- Cấu trúc thư mục Unity chuẩn: `Assets/Scenes`, `Assets/Scripts`, `Assets/Prefabs`, `Assets/Audio`, `Assets/Materials`
- Dễ mở rộng: thêm level mới bằng prefab/bệ đáp, thêm thử thách bằng tag/collider

## Cách chơi

- Mục tiêu: hạ cánh lên bệ đáp an toàn
- Va chạm vật cản sẽ thua, chạm vùng an toàn sẽ thắng và chuyển màn

## Điều khiển (mặc định trên PC)

- W hoặc Space: bật lực đẩy (thrust)
- A/D: xoay trái/phải
- Esc: thoát Play Mode (trong Editor)

## Cấu trúc quan trọng

- `Assets/Scripts/Movement.cs`: Xử lý input, áp lực đẩy và xoay, phát âm thanh/particle khi boost
- `Assets/Scripts/CollisionHandler.cs`: Lắng nghe `OnCollisionEnter`, quyết định trạng thái (thắng/thua), chuyển scene, phát hiệu ứng
- `Assets/Scenes/Under.unity`, `Assets/Scenes/Over.unity`: Ví dụ 2 màn cơ bản
- `Assets/Prefabs/`: Bệ đáp, hiệu ứng particle, đối tượng môi trường
- `Assets/Audio/`: `roket_boost.wav`, `crash.wav`, ... dùng cho phản hồi

## Yêu cầu môi trường

- Unity 2021 LTS hoặc mới hơn (khuyến nghị 2021.3+)
- Hệ điều hành: macOS/Windows/Linux

## Cách chạy dự án

1. Mở Unity Hub, chọn Open > trỏ tới thư mục dự án: `RocketGame`
2. Mở scene: `Assets/Scenes/Under.unity`
3. Nhấn Play để trải nghiệm

## Định hướng mở rộng (Roadmap ngắn)

- Thêm hệ thống UI: màn hình thắng/thua, timer, số mạng
- Bổ sung tutorial in-game và khó dần theo level
- Vật lý nâng cao: gió/độ trễ điều khiển, nhiên liệu hạn chế
- Build WebGL để dễ demo online

## Chất lượng & Quy ước code

- Tên biến/hàm có nghĩa, trách nhiệm rõ ràng theo component
- Tránh khối lệnh lồng sâu, dùng early-return cho nhánh lỗi/ngoại lệ
- Không bắt lỗi vô nghĩa; nếu cần, log rõ ràng
- Asset đặt tên nhất quán, có tiền tố theo loại (vd: `SFX_`, `VFX_`)

## Ảnh/GIF (tùy chọn)

Bạn có thể thêm ảnh/gif demo nhanh vào đây để tăng thiện cảm. Ví dụ:

```
Assets/Readme/demo.gif
```

## Liên hệ

- Tên: (Điền tên của bạn)
- Email: (Email chuyên nghiệp)
- LinkedIn/GitHub: (Liên kết cập nhật)

## Giấy phép

Mục đích chính là minh họa kỹ năng cá nhân. Tài sản âm thanh/hình ảnh thuộc quyền sở hữu tương ứng; không dùng cho thương mại nếu chưa có quyền.
