
using System.Text.RegularExpressions;

namespace InstagramSimulation.Helpers
{
    internal class ValidationHelper
    {
        // Email yoxlanışı
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var regex = new Regex(
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );

            return regex.IsMatch(email);
        }

        // Username yoxlanışı
        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            var regex = new Regex(
                @"^[a-zA-Z0-9._]{3,20}$"
            );

            return regex.IsMatch(username);
        }

        // Password yoxlanışı
        public static string GetPasswordValidationError(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return "Password boş ola bilməz!";

            if (password.Length < 8)
                return "Password minimum 8 simvol olmalıdır!";

            if (!Regex.IsMatch(password, @"[a-z]"))
                return "Password ən azı bir kiçik hərf daxil etməlidir!";

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return "Password ən azı bir böyük hərf daxil etməlidir!";

            if (!Regex.IsMatch(password, @"\d"))
                return "Password ən azı bir rəqəm daxil etməlidir!";

            if (!Regex.IsMatch(password, @"[@$!%*?&]"))
                return "Password ən azı bir xüsusi simvol daxil etməlidir!";

            return "";
        }

        // Telefon nömrəsi yoxlanışı
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Boşluq və defisləri təmizləyirik.
            string cleanedNumber = phoneNumber
                .Replace(" ", "")
                .Replace("-", "");

            var regex = new Regex(
                @"^\+?\d{10,15}$"
            );

            return regex.IsMatch(cleanedNumber);
        }

        // Ad və soyad yoxlanışı
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            var regex = new Regex(
                @"^[\p{L}\s-]{1,100}$"
            );

            return regex.IsMatch(name);
        }

        // Doğum tarixi və yaş yoxlanışı
        public static string GetBirthDateValidationError(
            DateTime birthDate,
            int minimumAge = 13)
        {
            if (birthDate.Date > DateTime.Today)
                return "Doğum tarixi gələcək tarix ola bilməz!";

            int age = DateTime.Today.Year - birthDate.Year;

            if (birthDate.Date > DateTime.Today.AddYears(-age))
                age--;

            if (age < minimumAge)
                return $"Qeydiyyat üçün minimum yaş {minimumAge} olmalıdır!";

            return "";
        }
    }
}
