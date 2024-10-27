using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANDPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra tuổi, giấy phép, và kinh nghiệm
        BaiTap2(); // Kiểm tra điều kiện vào công viên giải trí
        BaiTap3(); // Điều kiện đạt học bổng
        BaiTap4(); // Kiểm tra đăng ký hợp lệ
        BaiTap5(); // Kiểm tra điều kiện thi lại
        BaiTap6(); // Xét tuyển nhân viên
        BaiTap7(); // Kiểm tra điều kiện mua hàng
        BaiTap8(); // Đủ điều kiện nhận phần thưởng
        BaiTap9(); // Kiểm tra điều kiện thăng chức
        BaiTap10(); // Điều kiện nhận vé miễn phí
    }

    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe
        // Kiểm tra nếu người dùng trên 18 tuổi, có giấy phép lái xe, và có kinh nghiệm trên 1 năm
        int age = 20; // Tuổi của người dùng
        bool hasDriverLicense = true; // Kiểm tra có giấy phép lái xe
        float drivingExperience = 2; // Kinh nghiệm lái xe tính bằng năm
        if (age > 18 && hasDriverLicense && drivingExperience > 1)
        {
            Debug.Log("Bạn đủ điều kiện để lái xe.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện để lái xe.");
        }
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {
        // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
        // Kiểm tra nếu người dùng có vé, đã đăng ký trước, và không có tiền sử bệnh tim
        bool hasTicket = true; // Kiểm tra có vé không
        bool isRegistered = true; // Kiểm tra đã đăng ký trước chưa
        bool hasHeartCondition = true; // Kiểm tra có tiền sử bệnh tim không
        if (hasTicket && isRegistered && !hasHeartCondition)
        {
            Debug.Log("Bạn đủ điều kiện tham gia sự kiện.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện tham gia sự kiện.");
        }
    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        // Nhập điểm trung bình, điểm hoạt động ngoại khóa, và kiểm tra kỷ luật
        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
        float averageScore = 9.5f; // Điểm trung bình
        float extracurricularScore = 8.5f; // Điểm hoạt động ngoại khóa
        bool hasDisciplineViolation = true; // Kiểm tra vi phạm kỷ luật
        if (averageScore >= 9.0f && extracurricularScore >= 8.0f && !hasDisciplineViolation)
        {
            Debug.Log("Học sinh đủ điều kiện tham gia chương trình.");
        }
        else
        {
            Debug.Log("Học sinh không đủ điều kiện tham gia chương trình.");
        }
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        string email = "a@gmail.com"; // Thông tin email
        bool isPhoneVerified = true; // Kiểm tra đã xác nhận qua điện thoại
        bool hasPaidParticipationFee = true; // Kiểm tra đã thanh toán phí tham gia
        bool isValidEmail = email.Contains("@");

        if (isValidEmail && isPhoneVerified && hasPaidParticipationFee)
        {
            Debug.Log("Bạn đủ điều kiện tham gia sự kiện.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện tham gia sự kiện.");
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
        float finalScore = 4f; // Điểm tổng kết
        int failedSubjects = 2; // Số môn thi trượt
        float attendanceScore = 82f; // Điểm chuyên cần
        if (finalScore < 5.0f && failedSubjects <= 2 && attendanceScore > 75.0f)
        {
            Debug.Log("Học sinh không đủ điều kiện.");
        }
        else
        {
            Debug.Log("Học sinh đủ điều kiện.");
        }
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
        bool hasUniversityDegree = true; // Kiểm tra có bằng đại học không
        int yearsOfExperience = 3; // Kinh nghiệm làm việc tính bằng năm
        bool passedCompetencyTest = true; // Kiểm tra đã vượt qua bài kiểm tra năng lực chưa
        if (hasUniversityDegree && yearsOfExperience >= 2 && passedCompetencyTest)
        {
            Debug.Log("Ứng viên đủ điều kiện.");
        }
        else
        {
            Debug.Log("Ứng viên không đủ điều kiện.");
        }
    }

// Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
void BaiTap7()
    {
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
        float currentBalance = 60f; // Số tiền hiện có
        float productPrice = 50f; // Giá sản phẩm
        bool isItemInStock = true; // Kiểm tra hàng trong kho
        bool isEligibleForPromotion = true; // Kiểm tra đủ điều kiện tham gia khuyến mãi
        if (currentBalance >= productPrice && isItemInStock && isEligibleForPromotion)
        {
            Debug.Log("Bạn đủ điều kiện để mua hàng.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện để mua hàng.");
        }
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
        int completedTasks = 15; // Số nhiệm vụ đã hoàn thành
        float averageTaskScore = 8.3f; // Điểm trung bình của nhiệm vụ
        bool loggedInRecently = true; // Kiểm tra đã đăng nhập vào hệ thống trong 7 ngày qua
        if (completedTasks >= 10 && averageTaskScore >= 8.0f && loggedInRecently)
        {
            Debug.Log("Bạn đủ điều kiện tham gia chương trình.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện tham gia chương trình.");
        }

    }

// Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
void BaiTap9()
    {
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
        int yearsOfService = 6; // Số năm làm việc
        bool metJobQuota = true; // Kiểm tra đã đạt chỉ tiêu công việc chưa
        bool hasDisciplineViolation = true; // Kiểm tra có vi phạm kỷ luật không
        if (yearsOfService > 5 && metJobQuota && !hasDisciplineViolation)
        {
            Debug.Log("Nhân viên đủ điều kiện thăng chức.");
        }
        else
        {
            Debug.Log("Nhân viên không đủ điều kiện thăng chức.");
        }
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
        int age = 65; // Tuổi của người dùng
        bool isVIPMember = true; // Kiểm tra trạng thái thành viên VIP
        int ticketPurchasesThisYear = 5; // Số lần mua vé trong năm
        if (age > 60 && isVIPMember && ticketPurchasesThisYear >= 3)
        {
            Debug.Log("Bạn đủ điều kiện tham gia chương trình.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện tham gia chương trình.");
        }
    }
}
