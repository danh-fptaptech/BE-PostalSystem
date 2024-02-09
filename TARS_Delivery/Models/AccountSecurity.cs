namespace TARS_Delivery.Models
{
    public class AccountSecurity
    {
        public static string HashPassword(string password)
        {
            var salt = BCrypt.Net.BCrypt.GenerateSalt();
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }
        public static bool VerifyPassword(string password, string storeHashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, storeHashPassword);
        }
    }
}
