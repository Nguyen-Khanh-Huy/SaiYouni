using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
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
        // Sử dụng for để in tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để tính tổng tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Debug.Log(sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để tìm phần tử lớn nhất trong mảng
        int[] numbers = { 3, 5, 7, 2, 8, 1 };

        int maxElement = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxElement)
            {
                maxElement = numbers[i];
            }
        }

        Debug.Log(maxElement);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để đếm số lượng phần tử chẵn trong mảng
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int countEven = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                countEven++;
            }
        }

        Debug.Log(countEven);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng for để in tất cả các chuỗi trong danh sách
        List<string> stringList = new List<string>
        {
            "Hello",
            "Unity",
            "C#",
            "Programming",
            "Debugging"
        };

        for (int i = 0; i < stringList.Count; i++)
        {
            Debug.Log(stringList[i]);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng for để tìm chuỗi dài nhất trong danh sách
        List<string> stringList = new List<string>
        {
            "Hello",
            "Unity",
            "C#",
            "Programming",
            "Debugging",
            "Scripting in Unity"
        };

        string longestString = "";

        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i].Length > longestString.Length)
            {
                longestString = stringList[i];
            }
        }

        Debug.Log(longestString);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để tính tổng tất cả các số lẻ trong mảng
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int sumOdd = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                sumOdd += numbers[i];
            }
        }

        Debug.Log(sumOdd);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để in tất cả các số chẵn trong mảng
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Debug.Log(numbers[i]);
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        // Sử dụng for để kiểm tra xem phần tử đó có tồn tại trong mảng không
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int elementToCheck = 5;

        bool exists = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == elementToCheck)
            {
                exists = true;
                break;
            }
        }

        if (exists)
        {
            Debug.Log(elementToCheck + " Co Ton Tai");
        }
        else
        {
            Debug.Log(elementToCheck + " Khong Ton Tai");
        }
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để đếm số lượng các phần tử âm trong mảng
        int[] numbers = { -5, 2, -3, 4, 0, -1, 6, -7, 8, 10 };

        int countNegative = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                countNegative++;
            }
        }

        Debug.Log(countNegative);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để in các số lớn hơn 10 trong mảng
        int[] numbers = { 5, 12, 7, 20, 3, 15, 8, 10, 25, 6 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 10)
            {
                Debug.Log(numbers[i]);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng for để tìm chuỗi có độ dài ngắn nhất trong danh sách
        List<string> stringList = new List<string>
        {
            "Hello",
            "Unity",
            "C#",
            "Programming",
            "Debug"
        };

        string shortestString = stringList[0];

        for (int i = 1; i < stringList.Count; i++)
        {
            if (stringList[i].Length < shortestString.Length)
            {
                shortestString = stringList[i];
            }
        }

        Debug.Log(shortestString);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để nhân đôi tất cả các phần tử trong mảng
        int[] numbers = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 2;
        }

        Debug.Log(string.Join(", ", numbers));
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để tìm phần tử lớn thứ hai trong mảng
        int[] numbers = { 10, 20, 4, 45, 99, 99 };

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                secondLargest = largest;
                largest = numbers[i];
            }
            else if (numbers[i] > secondLargest && numbers[i] < largest)
            {
                secondLargest = numbers[i];
            }
        }

        if (secondLargest != int.MinValue)
        {
            Debug.Log(secondLargest);
        }
        else
        {
            Debug.Log("Khong co phan tu hop le");
        }
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng for để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        List<string> stringList = new List<string>
        {
            "Apple",
            "Banana",
            "Avocado",
            "Grapes",
            "Apricot",
            "Cherry"
        };

        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i].StartsWith("A"))
            {
                Debug.Log(stringList[i]);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng for để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        List<string> stringList = new List<string>
        {
            "Apple",
            "Banana",
            "Hello",
            "Grapes",
            "Avocado"
        };

        bool containsHello = false;

        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i] == "Hello")
            {
                containsHello = true;
                break;
            }
        }

        if (containsHello)
        {
            Debug.Log("DS co chua chuoi 'Hello'");
        }
        else
        {
            Debug.Log("DS khong chua chuoi 'Hello'");
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        // Sử dụng for để in ra tất cả các phần tử âm trong mảng
        int[] numbers = { -5, 2, -3, 4, 0, -1, 6, -7, 8, 10 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                Debug.Log(numbers[i]);
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng for để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int[] numbers = { 1, 2, 3, 4, 5, 3, 7, 3, 8, 9 };

        int elementToCount = 3;

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == elementToCount)
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
        // Sử dụng for để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        int[] arr = { 5, 12, 8, 20, 3, 15, 7, 30 };

        List<int> newArr = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 10)
            {
                newArr.Add(arr[i]);
            }
        }

        Debug.Log(string.Join(", ", newArr));
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng for để in các chuỗi có độ dài lớn hơn 5 ký tự
        List<string> strings = new List<string>
        {
            "Unity",
            "Programming",
            "C#",
            "Development",
            "Game",
            "Adventure"
        };

        for (int i = 0; i < strings.Count; i++)
        {
            if (strings[i].Length > 5)
            {
                Debug.Log(strings[i]);
            }
        }
    }
}
