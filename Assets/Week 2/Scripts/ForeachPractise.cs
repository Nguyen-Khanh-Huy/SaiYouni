using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int[] numbers = { 1, 5, 3, 9, 2 };

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Debug.Log(max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int evenCount = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Debug.Log(evenCount);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        List<string> stringList = new List<string> { "Hello", "World", "Unity", "C#" };

        foreach (string str in stringList)
        {
            Debug.Log(str);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        List<string> stringList = new List<string> { "Hello", "World", "Unity", "C#", "Programming" };

        string longestString = "";

        foreach (string str in stringList)
        {
            if (str.Length > longestString.Length)
            {
                longestString = str;
            }
        }

        Debug.Log(longestString);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int oddSum = 0;

        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                oddSum += number;
            }
        }

        Debug.Log(oddSum);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Debug.Log(number);
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int target = 5;

        bool exists = false;

        foreach (int number in numbers)
        {
            if (number == target)
            {
                exists = true;
                break;
            }
        }

        if (exists)
        {
            Debug.Log(target + " Co Ton Tai");
        }
        else
        {
            Debug.Log(target + " Khong Ton Tai");
        }
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        int[] numbers = { -5, 2, -3, 4, 0, -1, 6, -8, 10 };

        int negativeCount = 0;

        foreach (int number in numbers)
        {
            if (number < 0)
            {
                negativeCount++;
            }
        }

        Debug.Log(negativeCount);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        int[] numbers = { 5, 12, 3, 25, 8, 15, 7, 18, 9, 20 };

        foreach (int number in numbers)
        {
            if (number > 10)
            {
                Debug.Log(number);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        List<string> stringList = new List<string> { "Hello", "World", "Unity", "C#", "Programming" };

        string shortestString = stringList[0];

        foreach (string str in stringList)
        {
            if (str.Length < shortestString.Length)
            {
                shortestString = str;
            }
        }

        Debug.Log(shortestString);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            int doubled = number * 2;
            Debug.Log(doubled);
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        int[] numbers = { 5, 2, 9, 1, 7, 6 };

        // Khởi tạo các biến để lưu phần tử lớn nhất và lớn thứ hai
        int largest = int.MinValue; // Giá trị nhỏ nhất có thể
        int secondLargest = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                secondLargest = largest;
                largest = number;
            }
            else if (number > secondLargest && number < largest)
            {
                secondLargest = number;
            }
        }

        if (secondLargest != int.MinValue)
        {
            Debug.Log(secondLargest);
        }
        else
        {
            Debug.Log("Khong co phan tu nao hop le");
        }
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        List<string> stringList = new List<string> { "Apple", "Banana", "Avocado", "Cherry", "Apricot" };

        foreach (string str in stringList)
        {
            if (str.StartsWith("A"))
            {
                Debug.Log(str);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        List<string> stringList = new List<string> { "Hi", "Hello", "World", "Unity", "C#" };

        bool containsHello = false;

        foreach (string str in stringList)
        {
            if (str == "Hello")
            {
                containsHello = true;
                break;
            }
        }

        if (containsHello)
        {
            Debug.Log("DS co chuoi 'Hello'.");
        }
        else
        {
            Debug.Log("DS khong co chuoi 'Hello'.");
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        int[] numbers = { -5, 2, -3, 4, 0, -1, 6, -8, 10 };

        foreach (int number in numbers)
        {
            if (number < 0)
            {
                Debug.Log(number);
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int[] numbers = { 1, 2, 3, 4, 2, 5, 2, 6, 7, 8 };

        int target = 2;

        int count = 0;

        foreach (int number in numbers)
        {
            if (number == target)
            {
                count++;
            }
        }

        Debug.Log(count);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        int[] numbers = { 5, 12, 3, 25, 8, 15, 7, 18, 9, 20 };

        List<int> greaterThanTen = new List<int>();

        foreach (int number in numbers)
        {
            if (number > 10)
            {
                greaterThanTen.Add(number);
            }
        }

        foreach (int num in greaterThanTen)
        {
            Debug.Log(num);
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        List<string> stringList = new List<string> { "Hello", "World", "Unity", "Programming", "CSharp", "Debugging" };

        foreach (string str in stringList)
        {
            if (str.Length > 5)
            {
                Debug.Log(str);
            }
        }
    }

}
