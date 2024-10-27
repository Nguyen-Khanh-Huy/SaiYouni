using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tính giai thừa của một số
        BaiTap2(); // Tính tổng các số từ 1 đến n
        BaiTap3(); // Chuỗi Fibonacci
        BaiTap4(); // Đếm ngược từ n về 1
        BaiTap5(); // Tìm UCLN của hai số
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    void BaiTap1()
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính giai thừa của n
        int n = 5;

        if (n < 0)
        {
            Debug.Log("Vui lòng nhập số nguyên dương.");
        }
        else
        {
            long result = Factorial(n);
            Debug.Log($"Giai thừa của {n} là: {result}");
        }
    }
    long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2()
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        int n = 5;

        if (n < 1)
        {
            Debug.Log("Vui lòng nhập số nguyên dương.");
        }
        else
        {
            int result = Sum(n);
            Debug.Log($"Tổng các số từ 1 đến {n} là: {result}");
        }
    }
    int Sum(int n)
    {
        if (n == 1)
            return 1;
        return n + Sum(n - 1);
    }

    // Bài Tập 3: Chuỗi Fibonacci
    void BaiTap3()
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để tính số Fibonacci thứ n
        int n = 5;

        if (n < 0)
        {
            Debug.Log("Vui lòng nhập số nguyên không âm.");
        }
        else
        {
            int result = Fibonacci(n);
            Debug.Log($"Số Fibonacci thứ {n} là: {result}");
        }
    }
    int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4()
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để đếm ngược từ n về 1
        int n = 5;

        if (n < 1)
        {
            Debug.Log("Vui lòng nhập số nguyên dương.");
        }
        else
        {
            Debug.Log("Đếm ngược từ " + n + " về 1:");
            CountdownFrom(n);
        }
    }
    void CountdownFrom(int n)
    {
        Debug.Log(n);

        if (n <= 1)
            return;

        CountdownFrom(n - 1);
    }
    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    void BaiTap5()
    {
        // Nhập hai số nguyên a và b từ bàn phím
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
        int a = 48;
        int b = 18;

        if (a < 0 || b < 0)
        {
            Debug.Log("Vui lòng nhập các số nguyên không âm.");
        }
        else
        {
            int gcd = GCD(a, b);
            Debug.Log($"UCLN của {a} và {b} là: {gcd}");
        }
    }
    int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }
}
