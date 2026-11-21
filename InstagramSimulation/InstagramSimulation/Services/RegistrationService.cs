
using InstagramSimulation.Models;
using InstagramSimulation.Helpers;
using System.Linq;

namespace InstagramSimulation.Services
{
    internal class RegistrationService
    {
        private List<User> users;

        public RegistrationService(List<User> users)
        {
            this.users = users ?? new List<User>();
        }

        public void RegisterPersonalAccount(PersonalAccount account)
        {
            // 1. Null yoxlanışı
            if (account == null)
            {
                Console.WriteLine("Account bos ola bilmez!");
                return;
            }

            // 2. Ad yoxlanışı
            if (!ValidationHelper.IsValidName(account.Name))
            {
                Console.WriteLine("Ad duzgun formatda deyil!");
                return;
            }

            // 3. Soyad yoxlanışı
            if (!ValidationHelper.IsValidName(account.Surname))
            {
                Console.WriteLine("Soyad duzgun formatda deyil!");
                return;
            }

            // 4. Username yoxlanışı
            if (!ValidationHelper.IsValidUsername(account.UserName))
            {
                Console.WriteLine("Username duzgun formatda deyil!");
                return;
            }

            // 5. Email yoxlanışı
            if (!ValidationHelper.IsValidEmail(account.Email))
            {
                Console.WriteLine("Email duzgun formatda deyil!");
                return;
            }

            // 6. Password yoxlanışı
            string passwordError = account.GetPasswordValidationError();

            if (!string.IsNullOrEmpty(passwordError))
            {
                Console.WriteLine(passwordError);
                return;
            }

            // 7. Telefon yoxlanışı
            if (!ValidationHelper.IsValidPhoneNumber(account.PhoneNumber))
            {
                Console.WriteLine("Telefon nomresi duzgun formatda deyil!");
                return;
            }

            // 8. Doğum tarixi yoxlanışı
            string birthDateError =
                ValidationHelper.GetBirthDateValidationError(account.BirthDate);

            if (!string.IsNullOrEmpty(birthDateError))
            {
                Console.WriteLine(birthDateError);
                return;
            }

            // 9. Təkrarlanan username yoxlanışı
            if (IsUsernameTaken(account.UserName))
            {
                Console.WriteLine("Bu username artiq istifade olunur!");
                return;
            }

            // 10. Təkrarlanan email yoxlanışı
            if (IsEmailTaken(account.Email))
            {
                Console.WriteLine("Bu email artiq qeydiyyatdan kechib!");
                return;
            }

            // 11. Təkrarlanan telefon yoxlanışı
            if (IsPhoneNumberTaken(account.PhoneNumber))
            {
                Console.WriteLine("Bu telefon nomresi artiq istifade olunur!");
                return;
            }

            // 12. Qeydiyyat
            users.Add(account);

            Console.WriteLine("Qeydiyyat ugurla tamamlandi!");
        }

        public void RegisterBusinessAccount(BusinessAccount account)
        {
            if (account == null)
            {
                Console.WriteLine("Account boş ola bilməz!");
                return;
            }

            string passwordError = account.GetPasswordValidationError();

            if (!string.IsNullOrEmpty(passwordError))
            {
                Console.WriteLine(passwordError);
                return;
            }

            if (!ValidationHelper.IsValidName(account.Name) ||
                !ValidationHelper.IsValidName(account.Surname))
            {
                Console.WriteLine("Ad və ya soyad düzgün deyil!");
                return;
            }

            if (!ValidationHelper.IsValidUsername(account.UserName) ||
                !ValidationHelper.IsValidEmail(account.Email) ||
                !ValidationHelper.IsValidPhoneNumber(account.PhoneNumber))
            {
                Console.WriteLine("İstifadəçi məlumatları düzgün deyil!");
                return;
            }

            if (IsUsernameTaken(account.UserName))
            {
                Console.WriteLine("Bu username artıq istifadə olunur!");
                return;
            }

            if (IsEmailTaken(account.Email))
            {
                Console.WriteLine("Bu email artıq qeydiyyatdan keçib!");
                return;
            }

            if (IsPhoneNumberTaken(account.PhoneNumber))
            {
                Console.WriteLine("Bu telefon nömrəsi artıq istifadə olunur!");
                return;
            }

            users.Add(account);

            Console.WriteLine("Business Account qeydiyyatı uğurla tamamlandı!");
        }

        private bool IsUsernameTaken(string username)
        {
            return users.Any(u =>
                string.Equals(
                    u.UserName,
                    username,
                    StringComparison.OrdinalIgnoreCase
                ));
        }

        private bool IsEmailTaken(string email)
        {
            return users.Any(u =>
                string.Equals(
                    u.Email,
                    email,
                    StringComparison.OrdinalIgnoreCase
                ));
        }

        private bool IsPhoneNumberTaken(string phoneNumber)
        {
            return users.Any(u =>
                string.Equals(
                    u.PhoneNumber,
                    phoneNumber,
                    StringComparison.Ordinal
                ));
        }
    }
}
