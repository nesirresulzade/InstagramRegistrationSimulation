
namespace InstagramSimulation.Helpers
{
    internal class ValidationHelper
    {
        // Email yoxlanışı
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            int atIndex = email.IndexOf('@');

            // @ simvolu olmalıdır
            if (atIndex == -1)
                return false;

            // Yalnız bir @ olmalıdır
            if (email.LastIndexOf('@') != atIndex)
                return false;

            // @ simvolundan əvvəl və sonra məlumat olmalıdır
            if (atIndex == 0 || atIndex == email.Length - 1)
                return false;

            string domain = email.Substring(atIndex + 1);

            int dotIndex = domain.IndexOf('.');

            // Domain daxilində nöqtə olmalıdır
            if (dotIndex == -1)
                return false;

            // Nöqtə domain-in əvvəlində və sonunda ola bilməz
            if (dotIndex == 0 || dotIndex == domain.Length - 1)
                return false;

            // Nöqtədən sonra ən azı bir simvol olmalıdır
            return true;
        }


        // Username yoxlanışı
        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            if (username.Length < 3 || username.Length > 20)
                return false;

            for (int i = 0; i < username.Length; i++)
            {
                char character = username[i];

                if (!char.IsLetterOrDigit(character) &&
                    character != '.' &&
                    character != '_')
                {
                    return false;
                }
            }

            return true;
        }


        // Password yoxlanışı
        public static string GetPasswordValidationError(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return "Password bos ola bilmez!";

            if (password.Length < 8)
                return "Password minimum 8 simvol olmalidir!";

            bool hasLowercase = false;
            bool hasUppercase = false;
            bool hasDigit = false;
            bool hasSpecialCharacter = false;

            for (int i = 0; i < password.Length; i++)
            {
                char character = password[i];

                if (char.IsLower(character))
                    hasLowercase = true;

                if (char.IsUpper(character))
                    hasUppercase = true;

                if (char.IsDigit(character))
                    hasDigit = true;

                if (character == '@' ||
                    character == '$' ||
                    character == '!' ||
                    character == '%' ||
                    character == '*' ||
                    character == '?' ||
                    character == '&')
                {
                    hasSpecialCharacter = true;
                }
            }

            if (!hasLowercase)
                return "Password en azi bir kicik herf daxil etmelidir!";

            if (!hasUppercase)
                return "Password en azi bir boyuk herf daxil etmelidir!";

            if (!hasDigit)
                return "Password en azi bir reqem daxil etmelidir!";

            if (!hasSpecialCharacter)
                return "Password en azi bir xususi simvol daxil etmelidir!";

            return "";
        }


        // Telefon nömrəsi yoxlanışı
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Boşluq və defisləri təmizləyirik
            string cleanedNumber = phoneNumber
                .Replace(" ", "")
                .Replace("-", "");

            // + simvolu varsa, yalnız başlanğıcda ola bilər
            if (cleanedNumber.StartsWith("+"))
            {
                cleanedNumber = cleanedNumber.Substring(1);
            }

            // Rəqəmlərin uzunluğunu yoxlayırıq
            if (cleanedNumber.Length < 10 || cleanedNumber.Length > 15)
                return false;

            // Hər simvolun rəqəm olub-olmadığını yoxlayırıq
            for (int i = 0; i < cleanedNumber.Length; i++)
            {
                if (!char.IsDigit(cleanedNumber[i]))
                    return false;
            }

            return true;
        }


        // Ad və soyad yoxlanışı
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            if (name.Length > 100)
                return false;

            for (int i = 0; i < name.Length; i++)
            {
                char character = name[i];

                if (!char.IsLetter(character) &&
                    !char.IsWhiteSpace(character) &&
                    character != '-')
                {
                    return false;
                }
            }

            return true;
        }


        // Doğum tarixi və yaş yoxlanışı
        public static string GetBirthDateValidationError(
            DateTime birthDate,
            int minimumAge = 13)
        {
            if (birthDate.Date > DateTime.Today)
                return "Dogum tarixi gelecek tarix ola bilmez!";

            int age = DateTime.Today.Year - birthDate.Year;

            if (birthDate.Date > DateTime.Today.AddYears(-age))
                age--;

            if (age < minimumAge)
                return $"Qeydiyyat ucun minimum yas {minimumAge} olmalidir!";

            return "";
        }
    }
}