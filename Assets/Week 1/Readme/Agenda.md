# Agenda Phát Triển Game Week 1

## 1. Tìm Giá Trị Lớn Nhất Mà Int, Float và Double Trong Unity C# Có Thể Lưu Trữ
Giá trị lớn nhất mà int có thể lưu trữ là 2,147,483,647 (2^31 - 1).
Giá trị lớn nhất mà float có thể lưu trữ là khoảng 3.40282347E+38
Giá trị lớn nhất mà double có thể lưu trữ là khoảng 1.79769313486232E+308
## 2. Để Thiết Kế Ra Một Kế Hoạch Làm Game Trong 1 Tháng
* Tuần 1: Làm quen với Unity và C cơ bản

 Ngày 1-2: Cài đặt và làm quen Unity
- Cài đặt Unity và Visual Studio (dùng cho viết mã C).
- Tìm hiểu giao diện Unity: Hierarchy, Scene, Game, Inspector, Project.
- Tìm hiểu về GameObject và Component.
- Làm một vài ví dụ đơn giản với các GameObject (cắt ghép, di chuyển, xoay).

 Ngày 3-4: Học C cơ bản trong Unity
- Biến, kiểu dữ liệu, toán tử: học cách khai báo biến, sử dụng các kiểu dữ liệu cơ bản (int, float, string, bool).
- Cấu trúc điều khiển: if, else, switch.
- Vòng lặp: for, while.
- Thực hành viết các đoạn mã đơn giản trong Unity để điều khiển các đối tượng trong game (di chuyển một nhân vật, thay đổi màu sắc, etc.).

 Ngày 5-7: Scripting và Component trong Unity
- Script trong Unity: Cách thêm script vào GameObject.
- Tìm hiểu về Start() và Update() trong C.
- Tạo chuyển động đơn giản cho đối tượng bằng mã C.
- Input cơ bản: Nhận dữ liệu từ bàn phím và chuột để điều khiển đối tượng.

* Tuần 2: Xây dựng khung cơ bản cho game Tower Defense

 Ngày 8-10: Thiết kế bản đồ và môi trường
- Tạo scene cho game (bản đồ, background).
- Tạo các object như đường đi cho quân địch, tháp phòng thủ, và vị trí đặt tháp.
- Làm quen với Tilemaps hoặc Probuilder (công cụ để tạo bản đồ nhanh chóng trong Unity).

 Ngày 11-13: Định nghĩa các đối tượng chính
- Tạo class cho quân địch (enemy): Tạo GameObject đơn giản (vd: hình tròn), đặt tốc độ di chuyển và hướng di chuyển.
- Tạo class cho tháp (tower): GameObject tĩnh, có khả năng tấn công kẻ địch trong phạm vi.
- Thiết lập hệ thống health và damage cho cả enemy và tower.
  
 Ngày 14: Tạo đường đi cho quân địch
- Sử dụng NavMesh hoặc thuật toán di chuyển đường thẳng đơn giản.
- Quân địch sẽ di chuyển từ điểm đầu đến điểm cuối.

* Tuần 3: Hoàn thiện gameplay cơ bản

 Ngày 15-17: Phát triển hệ thống tấn công
- Tháp bắn đạn: Tạo hệ thống bắn đạn từ tháp, kiểm tra va chạm giữa đạn và quân địch.
- Kẻ địch bị tiêu diệt: Giảm máu của kẻ địch khi trúng đạn, loại bỏ khi máu về 0.
- Thêm hệ thống khoảng cách tấn công cho tháp.

 Ngày 18-19: Hệ thống sinh quân địch
- Tạo hệ thống sinh quân địch theo thời gian (Spawner).
- Quân địch xuất hiện theo từng đợt (wave).
  
 Ngày 20-21: Hệ thống xây dựng tháp
- Tạo hệ thống cho phép người chơi mua và đặt tháp lên bản đồ.
- Cài đặt giao diện cơ bản (UI) cho hệ thống xây dựng và nâng cấp tháp.

* Tuần 4: Hoàn thiện và tinh chỉnh dự án

 Ngày 22-24: Giao diện và trải nghiệm người chơi
- Thiết kế UI cơ bản: Thanh máu, điểm số, số lượng quân địch còn lại, số tiền để mua tháp.
- Tạo giao diện kết thúc khi người chơi thắng hoặc thua (game over).

 Ngày 25-27: Tối ưu hóa và chỉnh sửa
- Tối ưu hóa đường đi của quân địch.
- Tinh chỉnh mức độ khó, thêm nhiều loại quân địch và tháp khác nhau.
- Tinh chỉnh hiệu ứng (vd: hiệu ứng nổ khi quân địch bị tiêu diệt).

 Ngày 28-30: Đóng gói và xuất bản
- Đóng gói game thành file APK cho Android.
- Thử nghiệm trên các thiết bị di động.
- Tối ưu hóa hiệu suất trên mobile (fps, memory).

 Mục tiêu cuối tháng:
- Hoàn thành game Tower Defense cơ bản, có thể chạy trên thiết bị di động.
- Có khả năng sử dụng Unity và C để phát triển dự án game độc lập.
## 3. Khai Báo Thêm 5 Methods Cho Class Enemy
public float health = 100f;
    public float attackPower = 10f;
    
    // 1. Method để nhận sát thương
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // 2. Method để tấn công
    public void Attack(Player player)
    {
        player.TakeDamage(attackPower);
    }

    // 3. Method để hồi máu
    public void Heal(float amount)
    {
        health += amount;
        if (health > 100f) // Giới hạn hồi máu
        {
            health = 100f;
        }
    }

    // 4. Method để kiểm tra trạng thái sống
    public bool IsAlive()
    {
        return health > 0;
    }

    // 5. Method để xử lý khi chết
    private void Die()
    {
        Debug.Log("Enemy has died.");
        // Có thể thêm logic để xóa đối tượng, phát sinh hiệu ứng, v.v.
        Destroy(gameObject);
    }
## 4. Khai Báo Thêm 5 Biến Cho Class Enemy
// 1. Biến kiểu float để lưu trữ máu
    public float health = 100f;

    // 2. Biến kiểu int để lưu trữ sức tấn công
    public int attackPower = 10;

    // 3. Biến kiểu string để lưu trữ tên kẻ thù
    public string enemyName = "Goblin";

    // 4. Biến kiểu bool để kiểm tra trạng thái sống
    public bool isAlive = true;

    // 5. Biến kiểu Vector3 để lưu trữ vị trí của kẻ thù
    public Vector3 position;
## 5. Nhờ AI Giải Thích Câu Lệnh Này: `int[] scores = new int[10];`
Khai báo mảng: int[] scores khai báo một mảng có tên là scores, kiểu dữ liệu là int (số nguyên).
Khởi tạo mảng: new int[10] tạo một mảng mới với 10 phần tử, tất cả đều được khởi tạo với giá trị mặc định là 0.
Kết quả là scores là một mảng có 10 số nguyên, có thể lưu trữ điểm số hoặc giá trị tương tự.
## 6. Nhờ AI Giải Thích Về Rigidbody
Tính toán vật lý: Cho phép Unity xử lý các tác động vật lý như trọng lực, va chạm, và chuyển động.
Di chuyển và xoay: Có thể điều khiển vị trí và xoay của đối tượng thông qua các phương thức vật lý như AddForce hoặc MovePosition.
Cấu hình thuộc tính: Cung cấp các thuộc tính như khối lượng, lực kéo (drag), và lực cản (angular drag) để điều chỉnh hành vi vật lý của đối tượng.
Rigidbody rất hữu ích cho các trò chơi yêu cầu tính toán vật lý thực tế.
## 7. Hỏi AI Cách Chia Lấy Dư Một Số Bất Kỳ
Cú pháp:

csharp
Sao chép mã
int remainder = a % b;
Trong đó:

a là số chia (chia).
b là số chia (bất kỳ khác 0).
remainder sẽ lưu trữ phần dư của phép chia.
Ví dụ:

csharp
Sao chép mã
int remainder = 10 % 3; // remainder = 1
Phép chia này trả về phần dư của 10 khi chia cho 3.
## 8. Ngoài Các Kiểu Dữ Liệu Đã Giới Thiệu, Kể Tên 5 Kiểu Dữ Liệu Khác Của Unity C#
int, float, string, double, bool
## 9. Ngoài Các Toán Tử Đã Giới Thiệu, Hãy Kể Tên 3 Toán Tử Khác
==, !=, >, <
