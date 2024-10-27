# Agenda Phát Triển Game Week 3

## 1. Tìm Thêm 5 Characters Cho Game

- Nghiên cứu và chọn 5 nhân vật mới để thêm vào game.
- Tìm kiếm các nhân vật có phong cách và khả năng phù hợp với lối chơi của game.
- Đảm bảo rằng các nhân vật này được tối ưu hóa cho hiệu suất.

## 2. Gắn Animation Chạy (Run) Vào Cho 5 Characters Mới

- Gắn animation chạy mặc định vào từng nhân vật mới.
- Kiểm tra xem các animation có tương thích và hoạt động mượt mà trên các nhân vật.

## 3. Lần Lượt Gắn 3 Animation Chạy Khác Nhau Vào Animator

- Gắn ba animation chạy khác nhau vào hệ thống Animator của Unity.
- Thiết lập các transition (chuyển cảnh) giữa các animation để tạo sự linh hoạt cho các hành động của nhân vật.
- Kiểm tra tính đồng nhất giữa các animation trong quá trình chuyển tiếp.

## 4. Tìm Kiếm 2 Website Khác Ngoài Unity Store Cung Cấp Asset

- Tìm và đánh giá thêm 2 trang web cung cấp asset để làm phong phú nguồn tài nguyên cho dự án.

https://assetstore.unity.com/
https://craftpix.net/

- Một số trang web có thể tham khảo bao gồm:
  - **CGTrader**: Chuyên cung cấp asset 3D.
  - **TurboSquid**: Một trang web uy tín với nhiều asset cho các dự án game và phim.
- Xem xét độ tương thích của các asset với Unity và dự án hiện tại.

## 5. Hỏi AI Cách Sử Dụng Nav Mesh Obstacle

1. Thêm NavMesh Obstacle vào Vật Cản
Trong Hierarchy, tạo hoặc chọn một đối tượng muốn sử dụng làm vật cản (ví dụ: tường, cây, hộp).
Trong Inspector, nhấp Add Component > NavMesh Obstacle.
Đảm bảo đối tượng có Collider, vì NavMesh Obstacle cần Collider để xác định vùng va chạm.
2. Thiết Lập Các Thuộc Tính Cơ Bản
Carve: Chọn Carve nếu muốn đối tượng này có khả năng cắt phần NavMesh xung quanh nó, tạo ra một lỗ hổng mà nhân vật không thể đi qua. Nếu bỏ chọn Carve, đối tượng sẽ không ảnh hưởng đến NavMesh xung quanh, nhưng các nhân vật AI vẫn có thể phát hiện và tránh va chạm với nó.
Carve Only Stationary: Tích vào mục này nếu đối tượng không di chuyển (ví dụ: tường cố định) để tiết kiệm hiệu suất.
Move Threshold và Time To Stationary: Điều chỉnh các giá trị này nếu muốn đối tượng có thể thay đổi NavMesh khi di chuyển. Điều này giúp NavMesh phản ứng linh hoạt hơn với vật cản di chuyển.
3. Kiểm Tra và Điều Chỉnh NavMesh
Đảm bảo đã tạo NavMesh cho scene bằng cách chọn Window > AI > Navigation.
Ở Bake tab, nhấn Bake để tạo lại NavMesh sau khi thêm hoặc điều chỉnh các vật cản.
Chỉnh Agent Radius, Agent Height, và Step Height để các nhân vật AI có thể đi qua hoặc tránh các khu vực có NavMesh Obstacle.
4. Kiểm Tra Trực Tiếp Trong Code
Bạn có thể điều chỉnh thuộc tính NavMesh Obstacle trong mã C# như sau:

csharp
Sao chép mã
using UnityEngine;
using UnityEngine.AI;

public class ObstacleController : MonoBehaviour
{
    private NavMeshObstacle obstacle;

    void Start()
    {
        obstacle = GetComponent<NavMeshObstacle>();

        // Kích hoạt carving nếu đối tượng này là vật cản di động
        obstacle.carving = true;
        obstacle.carveOnlyStationary = false;
    }

    void Update()
    {
        // Kiểm tra nếu đối tượng đã di chuyển và cần cập nhật carving
        if (obstacle.carving)
        {
            obstacle.carving = false;
            obstacle.carving = true; // Reset carving để cập nhật vị trí mới của vật cản
        }
    }
}
5. Cân Nhắc Hiệu Suất
Chỉ sử dụng Carve khi thật sự cần thiết, vì carving yêu cầu tính toán NavMesh lại thường xuyên.
Nếu có nhiều đối tượng di động cần carving, hãy thử tối ưu hóa bằng cách giảm Update Interval trong phần Carve Settings.

- Tìm hiểu cách sử dụng **NavMesh Obstacle** để chặn đường hoặc tạo vật cản cho các nhân vật điều hướng (navigation) trong game.
- Xem xét cách thiết lập các thuộc tính như "carving" để nhân vật tránh hoặc phản ứng linh hoạt với vật cản.
- Kiểm tra và điều chỉnh hệ thống **NavMesh** cho phù hợp với các vật cản mới.
