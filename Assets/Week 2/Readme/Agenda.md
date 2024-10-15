# Agenda Phát Triển Game Week 2

## 1. Kể Tên 3 Hàm Màu Xanh (Blue) Mà Unity Sẽ Tự Động Gọi
Awake(). Start(). Update()
## 2. Kể Tên 5 Loại Giải Thuật Sắp Xếp Khác Nhau
Bubble Sort, Selection Sort, Insertion Sort, Merge Sort, Quick Sort
## 3. Dùng Một Giải Thuật Sắp Xếp Khác Để Thay Cho Giải Thuật Trong Buổi Học
Quick Sort
## 4. Thực Hiện Random Cho Current HP
    private int currentHP;
    private void Start()
    {
        currentHP = Random.Range(0, 100);
        Debug.Log("Current HP: " + currentHP);
    }
- Sử dụng code để thực hiện random cho giá trị **Current HP** của nhân vật hoặc đối tượng trong game.
## 5. Tìm Enemy Có Current HP Nhỏ Nhất

- Viết code tìm đối tượng enemy có **Current HP** nhỏ nhất trong danh sách enemy.
public class Enemy : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;

    private void Start()
    {
        currentHP = Random.Range(0, maxHP + 1);
    }
}
public class GameManager : MonoBehaviour
{
    public List<Enemy> enemies;

    private void Start()
    {
        Enemy weakestEnemy = FindWeakestEnemy();
        if (weakestEnemy != null)
        {
            Debug.Log("Weakest Enemy HP: " + weakestEnemy.currentHP);
        }
        else
        {
            Debug.Log("No enemies found.");
        }
    }

    Enemy FindWeakestEnemy()
    {
        Enemy weakest = null;

        foreach (Enemy enemy in enemies)
        {
            if (weakest == null || enemy.currentHP < weakest.currentHP)
            {
                weakest = enemy;
            }
        }

        return weakest;
    }
}
## 6. Tìm Enemy Có Current HP Lớn Nhất
public class Enemy : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;

    private void Start()
    {
        currentHP = Random.Range(0, maxHP + 1);
    }
}
public class GameManager : MonoBehaviour
{
    public List<Enemy> enemies;

    private void Start()
    {
        Enemy weakestEnemy = FindWeakestEnemy();
        if (weakestEnemy != null)
        {
            Debug.Log("Weakest Enemy HP: " + weakestEnemy.currentHP);
        }
        else
        {
            Debug.Log("No enemies found.");
        }
    }

    Enemy FindWeakestEnemy()
    {
        Enemy weakest = null;

        foreach (Enemy enemy in enemies)
        {
            if (weakest == null || enemy.currentHP > weakest.currentHP)
            {
                weakest = enemy;
            }
        }

        return weakest;
    }
}
- Viết code tìm đối tượng enemy có **Current HP** lớn nhất trong danh sách enemy.

## 7. Bài Tập Về If Để Thực Hành

- Đọc IFStatementPractices.md

## 8. Bài Tập Về Foreach Để Thực Hành

- Đọc ForeachPractices.md

## 9. Bài Tập Về For Để Thực Hành

- Đọc ForPractices.md
