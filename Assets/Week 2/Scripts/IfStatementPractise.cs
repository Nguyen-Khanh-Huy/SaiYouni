using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class IfStatementPractise : MonoBehaviour
{
    public InputField inputField01;
    public InputField inputField02;
    public InputField inputField03;
    public Toggle toggle;
    public Text resultText;
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    public void BaiTap1()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if (float.TryParse(inputField01.text, out float number))
        {
            // Kiểm tra số dương, âm hay bằng 0
            if (number > 0)
            {
                resultText.text = "So Duong";
            }
            else if (number < 0)
            {
                resultText.text = "So Am";
            }
            else
            {
                resultText.text = "Bang 0";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    public void BaiTap2()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if (int.TryParse(inputField01.text, out int number))
        {
            if (number % 2 == 0)
            {
                resultText.text = "So Chan";
            }
            else
            {
                resultText.text = "So Le";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    public void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if (float.TryParse(inputField01.text, out float averageGrade))
        {
            // Kiểm tra điểm trung bình
            if (averageGrade >= 5.0f)
            {
                resultText.text = "HS Do";
            }
            else
            {
                resultText.text = "HS Truot";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    public void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        if (int.TryParse(inputField01.text, out int firstNumber) &&
            int.TryParse(inputField02.text, out int secondNumber))
        {
            int maxNumber = Mathf.Max(firstNumber, secondNumber);
            resultText.text = "So Lon Nhat La: " + maxNumber;
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    public void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        if (float.TryParse(inputField01.text, out float money) &&
            float.TryParse(inputField02.text, out float price))
        {
            // Kiểm tra xem người dùng có đủ tiền không
            if (money >= price)
            {
                resultText.text = "Ban du tien de mua sp";
            }
            else
            {
                resultText.text = "Ban khong du tien de mua sp";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    public void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if (int.TryParse(inputField01.text, out int year))
        {
            // Kiểm tra năm nhuận
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            if (isLeapYear)
            {
                resultText.text = year + " La Nam Nhuan";
            }
            else
            {
                resultText.text = year + " Khong Phai Nam Nhuan";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    public void BaiTap7()
    {
        // Nhập tuổi của người mua vé từ bàn phím
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        if (int.TryParse(inputField01.text, out int age))
        {
            // Kiểm tra giá vé theo độ tuổi
            int ticketPrice = (age < 18) ? 50000 : 100000;
            resultText.text = "Gia ve la: " + ticketPrice + " Dong";
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    public void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        if (float.TryParse(inputField01.text, out float averageGrade))
        {
            // Kiểm tra danh hiệu xuất sắc
            if (averageGrade >= 9.0f)
            {
                resultText.text = "HS Dat Danh Hieu Xuat Sac";
            }
            else
            {
                resultText.text = "HS Khong Dat Danh Hieu Xuat Sac";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 9: So Sánh Ba Số
    public void BaiTap9()
    {
        // Nhập ba số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        int firstNumber, secondNumber, thirdNumber;

        if (int.TryParse(inputField01.text, out firstNumber) &&
            int.TryParse(inputField02.text, out secondNumber) &&
            int.TryParse(inputField03.text, out thirdNumber))
        {
            int maxNumber = Mathf.Max(firstNumber, Mathf.Max(secondNumber, thirdNumber));
            resultText.text = "Max: " + maxNumber;
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 10: Tính Tiền Lương
    public void BaiTap10()
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        float hoursWorked;
        float fixedRate;

        if (float.TryParse(inputField01.text, out hoursWorked) &&
            float.TryParse(inputField02.text, out fixedRate))
        {
            float salary;

            if (hoursWorked > 40)
            {
                salary = (40 * fixedRate) + ((hoursWorked - 40) * (fixedRate / 40));
            }
            else
            {
                salary = hoursWorked * fixedRate;
            }

            resultText.text = "Luong: " + salary + " Dong";
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    public void BaiTap11()
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        if (int.TryParse(inputField01.text, out int age))
        {
            if (age > 18 && toggle.isOn == true)
            {
                resultText.text = "Ban Duoc Vao Cau Lac Bo";
            }
            else
            {
                resultText.text = "Ban Khong Duoc Vao Cau Lac Bo";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 12: Phân Loại Học Sinh
    public void BaiTap12()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        if (float.TryParse(inputField01.text, out float averageGrade))
        {
            string classification;

            if (averageGrade >= 9.0f)
            {
                classification = "Xuat Sac";
            }
            else if (averageGrade >= 8.0f)
            {
                classification = "Gioi";
            }
            else if (averageGrade >= 7.0f)
            {
                classification = "Kha";
            }
            else if (averageGrade >= 5.0f)
            {
                classification = "Trung Binh";
            }
            else
            {
                classification = "Yeu";
            }

            resultText.text = "Hoc Sinh Duoc Phan Loai: " + classification;
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 13: Tính Tiền Điện
    public void BaiTap13()
    {
        // Nhập số điện tiêu thụ từ bàn phím
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        if (float.TryParse(inputField01.text, out float consumption))
        {
            float bill;

            if (consumption <= 100)
            {
                bill = consumption * 1500;
            }
            else
            {
                bill = consumption * 2000;
            }

            resultText.text = "Tien Dien: " + bill + " Dong";
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    public void BaiTap14()
    {
        // Nhập số năm làm việc và đánh giá công việc
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        if (int.TryParse(inputField01.text, out int yearsWorked))
        {
            if (yearsWorked > 5 && toggle.isOn == true)
            {
                resultText.text = "Ban Du DK Thang Chuc";
            }
            else
            {
                resultText.text = "Ban Khong Du DK Thang Chuc";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    public void BaiTap15()
    {
        // Nhập giá trị đơn hàng từ bàn phím
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        if (float.TryParse(inputField01.text, out float orderValue))
        {
            if (orderValue >= 500000)
            {
                resultText.text = "Ban duoc Mien Phi van chuyen";
            }
            else
            {
                resultText.text = "Ban Khong duoc Mien Phi van chuyen";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    public void BaiTap16()
    {
        // Nhập thu nhập từ bàn phím
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        if (float.TryParse(inputField01.text, out float income))
        {
            float tax;

            if (income <= 5000000)
            {
                tax = income * 0.05f;
            }
            else if (income <= 10000000)
            {
                tax = income * 0.1f;
            }
            else
            {
                tax = income * 0.15f;
            }

            resultText.text = "Thue TNCN: " + tax + " Dong";
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    public void BaiTap17()
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        float score1, score2, score3;

        if (float.TryParse(inputField01.text, out score1) &&
            float.TryParse(inputField02.text, out score2) &&
            float.TryParse(inputField03.text, out score3))
        {
            float averageScore = (score1 + score2 + score3) / 3;

            if (averageScore >= 5.0f)
            {
                resultText.text = "HS Dat Yeu Cau: " + averageScore;
            }
            else
            {
                resultText.text = "HS Khong Dat Yeu Cau: " + averageScore;
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    public void BaiTap18()
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        if (int.TryParse(inputField01.text, out int value))
        {
            if (value < 100 && toggle.isOn == true)
            {
                resultText.text = "Co the nhap them hang";
            }
            else
            {
                resultText.text = "Khong the nhap them hang";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    public void BaiTap19()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        if (float.TryParse(inputField01.text, out float value))
        {
            if (value > 10)
            {
                resultText.text = "Lon Hon 10";
            }
            else
            {
                resultText.text = "Nho Hon 10";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    public void BaiTap20()
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        if (float.TryParse(inputField01.text, out float score))
        {
            if (score >= 8.0f && toggle.isOn == true)
            {
                resultText.text = "Ban du DK dang ky khoa hoc nang cao";
            }
            else
            {
                resultText.text = "Ban Khong du DK dang ky khoa hoc nang cao";
            }
        }
        else
        {
            resultText.text = "Vui Long Nhap So Hop Le";
        }
    }
}
