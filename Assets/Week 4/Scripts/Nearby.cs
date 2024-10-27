using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nearby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tìm kẻ địch gần nhất
        BaiTap2(); // Tìm vật phẩm gần nhất
    }

    // Bài Tập 1: Tìm Kẻ Địch Gần Nhất
    void BaiTap1()
    {
        // Tạo danh sách các kẻ địch với tọa độ (x, y, z) trong không gian 3D
        // Vị trí của người chơi được cung cấp
        // Sử dụng công thức khoảng cách Euclid hoặc Vector3.Distance() để tính khoảng cách
        // So sánh khoảng cách và tìm kẻ địch gần nhất
        // Trả về thông tin của kẻ địch gần nhất
        var DistanceMin = Mathf.Infinity;
        Vector3 Player = Vector3.zero;
        Vector3 EnemyNear = Vector3.zero;
        List<Vector3> enemies = new List<Vector3>
        {
            new Vector3(1, 2, 3),
            new Vector3(4, 5, 6),
            new Vector3(7, 8, 9)
        };
        for (int i = 0; i < enemies.Count; i++)
        {
            var enemiesIdx = enemies[i];
            if(Vector3.Distance(Player, enemiesIdx) < DistanceMin)
            {
                EnemyNear = enemiesIdx;
                DistanceMin = Vector3.Distance(Player, EnemyNear);
            }
        }
        Debug.Log("Ke Dich Gan Nhat La: "+ EnemyNear);
    }

    // Bài Tập 2: Tìm Vật Phẩm Gần Nhất
    void BaiTap2()
    {
        // Tạo danh sách các vật phẩm với tọa độ (x, y) trong không gian 2D
        // Vị trí của người chơi được cung cấp
        // Tính khoảng cách từ người chơi đến từng vật phẩm
        // So sánh để tìm vật phẩm gần nhất
        // Trả về thông tin của vật phẩm gần nhất
        var DistanceMin = Mathf.Infinity;
        Vector2 Player = Vector2.zero;
        Vector2 EnemyNear = Vector2.zero;
        List<Vector2> enemies = new List<Vector2>
        {
            new Vector2(1, 2),
            new Vector2(3, 4),
            new Vector2(5, 6)
        };
        for (int i = 0; i < enemies.Count; i++)
        {
            var enemiesIdx = enemies[i];
            if (Vector2.Distance(Player, enemiesIdx) < DistanceMin)
            {
                EnemyNear = enemiesIdx;
                DistanceMin = Vector2.Distance(Player, EnemyNear);
            }
        }
        Debug.Log("Vat Pham Gan Nhat La: " + EnemyNear);
    }
}
