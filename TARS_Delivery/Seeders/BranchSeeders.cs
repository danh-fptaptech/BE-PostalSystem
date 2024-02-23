using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders;

public class BranchSeeders
{
    public BranchSeeders(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>().HasData(
            new Branch { Id = 1, BranchName = "Bưu cục cấp 1 Giao dịch Sài Gòn", Address = "Số 2, đường Công Xã Paris, phường Bến Nghé", Province = "Ho Chi Minh", District = "Quan 1" , PostalCode = "700000", PhoneNumber = "0123123123", Status = EStatusData.Active},
            new Branch { Id = 2, BranchName = "Bưu cục cấp 3 Lê Hồng Phong", Address = "Khối Tân Thanh (Tổ 1-4), Phường Tân An", Province = "Quảng Nam", District = "Hội An" , PostalCode = "563870", PhoneNumber = "0123123132", Status = EStatusData.Active},
            new Branch { Id = 3, BranchName = "Bưu cục cấp 1 GD Cấp 1 Tây Ninh", Address = "Số 186, Đường 30/4, Phường 3", Province = "Tây Ninh", District = "Tây Ninh" , PostalCode = "840000", PhoneNumber = "0123123333", Status = EStatusData.Active},
            new Branch { Id = 4, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 5, BranchName = "Bưu cục cấp 2 Quận 5", Address = "Số 26, Đường Nguyễn Thi, Phường Số 13", Province = "Hồ Chí Minh", District = "Quận 5" , PostalCode = "749000", PhoneNumber = "0123123345", Status = EStatusData.Active},
            new Branch { Id = 6, BranchName = "Bưu cục cấp 3 Ngô Quyền", Address = "Số 237, Đường Ngô Quyền, Phường Số 6", Province = "Hồ Chí Minh", District = "Quận 10" , PostalCode = "740100", PhoneNumber = "0123123346", Status = EStatusData.Active}
            /*new Branch { Id = 7, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 8, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 9, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 10, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 11, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 12, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 13, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 14, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active},
            new Branch { Id = 15, BranchName = "Bưu cục cấp 3 Hưng Lợi", Address = "Số 190, Đường 30 Tháng 4, Phường Hưng Lợi", Province = "Cần Thơ", District = "Quận Ninh Kiều" , PostalCode = "902220", PhoneNumber = "0123123343", Status = EStatusData.Active}*/
        );
    }
}