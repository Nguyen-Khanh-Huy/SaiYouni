using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra vé vào cửa
        BaiTap2(); // Điều kiện trúng thưởng
        BaiTap3(); // Kiểm tra điều kiện vay tiền
        BaiTap4(); // Điều kiện nhận học bổng
        BaiTap5(); // Kiểm tra đăng ký sự kiện
        BaiTap6(); // Điều kiện lái xe
        BaiTap7(); // Kiểm tra quyền truy cập tài liệu
        BaiTap8(); // Kiểm tra điều kiện tham gia khóa học
        BaiTap9(); // Điều kiện tải ứng dụng miễn phí
        BaiTap10(); // Điều kiện sử dụng dịch vụ đặc biệt
    }

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1()
    {
        // Kiểm tra xem người dùng có thể vào sự kiện nếu có vé hợp lệ, là thành viên VIP, hoặc được mời
        bool hasValidTicket = false; // Kiểm tra vé hợp lệ
        bool isVIP = false; // Kiểm tra thành viên VIP
        bool isInvited = false; // Kiểm tra đã được mời
        if (hasValidTicket || isVIP || isInvited)
        {
            Debug.Log("Bạn có quyền vào sự kiện.");
        }
        else
        {
            Debug.Log("Bạn không có quyền vào sự kiện.");
        }
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2()
    {
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
        int userTicketNumber = 123; // Số vé của người dùng
        List<int> firstPrizeNumbers = new List<int> { 123, 456, 789 }; // Số vé trúng giải nhất
        List<int> secondPrizeNumbers = new List<int> { 234, 567, 890 }; // Số vé trúng giải nhì
        List<int> thirdPrizeNumbers = new List<int> { 345, 678, 901 }; // Số vé trúng giải ba
        if (firstPrizeNumbers.Contains(userTicketNumber))
        {
            Debug.Log("Bạn đã trúng giải nhất!");
        }
        else if (secondPrizeNumbers.Contains(userTicketNumber))
        {
            Debug.Log("Bạn đã trúng giải nhì!");
        }
        else if (thirdPrizeNumbers.Contains(userTicketNumber))
        {
            Debug.Log("Bạn đã trúng giải ba!");
        }
        else
        {
            Debug.Log("Bạn không trúng thưởng.");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3()
    {
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh
        bool hasStableIncome = false; // Kiểm tra thu nhập ổn định
        bool hasCollateral = false; // Kiểm tra tài sản thế chấp
        bool hasGuarantor = false; // Kiểm tra người bảo lãnh
        if (hasStableIncome || hasCollateral || hasGuarantor)
        {
            Debug.Log("Bạn đủ điều kiện để vay tiền.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện để vay tiền.");
        }
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4()
    {
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
        bool hasExcellentAcademicPerformance = false; // Thành tích học tập xuất sắc
        bool hasGoodExtracurricularActivities = false; // Hoạt động ngoại khóa tốt
        bool comesFromLowIncomeFamily = false; // Gia đình khó khăn
        if (hasExcellentAcademicPerformance || hasGoodExtracurricularActivities || comesFromLowIncomeFamily)
        {
            Debug.Log("Học sinh đủ điều kiện nhận học bổng.");
        }
        else
        {
            Debug.Log("Học sinh không đủ điều kiện nhận học bổng.");
        }
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5()
    {
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
        bool hasValidEmail = false; // Kiểm tra email hợp lệ
        bool hasVerifiedPhoneNumber = false; // Kiểm tra số điện thoại xác thực
        bool isRegisteredThroughWebsite = false; // Kiểm tra đã đăng ký qua trang web
        if (hasValidEmail || hasVerifiedPhoneNumber || isRegisteredThroughWebsite)
        {
            Debug.Log("Bạn có thể đăng ký sự kiện.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện để đăng ký sự kiện.");
        }
    }

    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6()
    {
        // Kiểm tra xem người dùng có thể lái xe nếu có bằng lái, đã đăng ký xe hợp lệ, hoặc có bảo hiểm xe
        bool hasDriverLicense = false; // Kiểm tra có bằng lái
        bool isCarRegistered = false; // Kiểm tra đã đăng ký xe hợp lệ
        bool hasCarInsurance = false; // Kiểm tra có bảo hiểm xe
        if (hasDriverLicense && isCarRegistered && hasCarInsurance)
        {
            Debug.Log("Bạn đủ điều kiện để lái xe.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện để lái xe.");
        }
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7()
    {
        // Kiểm tra xem người dùng có quyền truy cập tài liệu nếu là quản trị viên, được cấp quyền truy cập từ quản lý, hoặc có mã xác thực
        bool isAdmin = false; // Kiểm tra xem có phải quản trị viên không
        bool hasManagerApproval = false; // Kiểm tra đã được cấp quyền từ quản lý chưa
        bool hasAccessCode = false; // Kiểm tra có mã xác thực không
        if (isAdmin || hasManagerApproval || hasAccessCode)
        {
            Debug.Log("Bạn có quyền truy cập tài liệu.");
        }
        else
        {
            Debug.Log("Bạn không có quyền truy cập tài liệu.");
        }
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8()
    {
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
        bool hasTeacherRecommendation = false; // Kiểm tra có thư giới thiệu từ giáo viên
        bool hasPassedEntranceExam = false; // Kiểm tra đã hoàn thành bài kiểm tra đầu vào
        bool hasRelatedExperience = false; // Kiểm tra có kinh nghiệm liên quan
        if (hasTeacherRecommendation || hasPassedEntranceExam || hasRelatedExperience)
        {
            Debug.Log("Học sinh đủ điều kiện tham gia khóa học đặc biệt.");
        }
        else
        {
            Debug.Log("Học sinh không đủ điều kiện tham gia khóa học đặc biệt.");
        }
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9()
    {
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
        bool hasPromoCode = false; // Kiểm tra có mã khuyến mãi
        bool isVIPMember = false; // Kiểm tra có phải là thành viên VIP không
        bool isAppFreePeriod = false; // Kiểm tra ứng dụng đang trong thời gian miễn phí
        if (hasPromoCode || isVIPMember || isAppFreePeriod)
        {
            Debug.Log("Bạn có thể tải ứng dụng miễn phí.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện để tải ứng dụng miễn phí.");
        }
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10()
    {
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
        float spendingAmount = 0f; // Số tiền đã chi tiêu
        float requiredSpendingThreshold = 100f; // Mức chi tiêu yêu cầu
        bool isLoyalCustomer = false; // Kiểm tra có phải khách hàng thân thiết không
        bool hasPromotion = false; // Kiểm tra có chương trình khuyến mãi không
        if (spendingAmount > requiredSpendingThreshold || isLoyalCustomer || hasPromotion)
        {
            Debug.Log("Khách hàng có thể sử dụng dịch vụ đặc biệt.");
        }
        else
        {
            Debug.Log("Khách hàng không đủ điều kiện để sử dụng dịch vụ đặc biệt.");
        }
    }
}
