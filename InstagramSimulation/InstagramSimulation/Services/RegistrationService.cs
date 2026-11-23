
using InstagramSimulation.Models;
using InstagramSimulation.Helpers;
using System;

namespace InstagramSimulation.Services
{
    internal class RegistrationService
    {
        private User[] users;

        public RegistrationService(User[] users)
        {
            this.users = users ?? new User[0];
        }

        // Qeydiyyatdan keçmiş user-ləri əldə etmək
        public User[] Users
        {
            get { return users; }
        }

        // PERSONAL ACCOUNT
        public void RegisterPersonalAccount(PersonalAccount account)
        {
            if (account == null)
            {
                Console.WriteLine("Account boş ola bilməz!");
                return;
            }

            if (!ValidationHelper.IsValidName(account.Name) ||
                !ValidationHelper.IsValidName(account.Surname))
            {
                Console.WriteLine("Ad və ya soyad düzgün deyil!");
                return;
            }

            if (!ValidationHelper.IsValidUsername(account.UserName))
            {
                Console.WriteLine("Username düzgün formatda deyil!");
                return;
            }

            if (!ValidationHelper.IsValidEmail(account.Email))
            {
                Console.WriteLine("Email düzgün formatda deyil!");
                return;
            }

            string passwordError = account.GetPasswordValidationError();

            if (!string.IsNullOrEmpty(passwordError))
            {
                Console.WriteLine(passwordError);
                return;
            }

            if (!ValidationHelper.IsValidPhoneNumber(account.PhoneNumber))
            {
                Console.WriteLine("Telefon nömrəsi düzgün deyil!");
                return;
            }

            string birthDateError =
                ValidationHelper.GetBirthDateValidationError(account.BirthDate);

            if (!string.IsNullOrEmpty(birthDateError))
            {
                Console.WriteLine(birthDateError);
                return;
            }

            // Duplicate yoxlamaları
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

            AddUser(account);

            Console.WriteLine("Personal Account qeydiyyatı uğurla tamamlandı!");
        }

        // BUSINESS ACCOUNT
        public void RegisterBusinessAccount(BusinessAccount account)
        {
            if (account == null)
            {
                Console.WriteLine("Account boş ola bilməz!");
                return;
            }

            if (!ValidationHelper.IsValidName(account.Name) ||
                !ValidationHelper.IsValidName(account.Surname))
            {
                Console.WriteLine("Ad və ya soyad düzgün deyil!");
                return;
            }

            if (!ValidationHelper.IsValidUsername(account.UserName))
            {
                Console.WriteLine("Username düzgün formatda deyil!");
                return;
            }

            if (!ValidationHelper.IsValidEmail(account.Email))
            {
                Console.WriteLine("Email düzgün formatda deyil!");
                return;
            }

            string passwordError = account.GetPasswordValidationError();

            if (!string.IsNullOrEmpty(passwordError))
            {
                Console.WriteLine(passwordError);
                return;
            }

            if (!ValidationHelper.IsValidPhoneNumber(account.PhoneNumber))
            {
                Console.WriteLine("Telefon nömrəsi düzgün deyil!");
                return;
            }

            string birthDateError =
                ValidationHelper.GetBirthDateValidationError(account.BirthDate);

            if (!string.IsNullOrEmpty(birthDateError))
            {
                Console.WriteLine(birthDateError);
                return;
            }

            // Duplicate yoxlamaları
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

            AddUser(account);

            Console.WriteLine("Business Account qeydiyyatı uğurla tamamlandı!");
        }

        // AVAILABILITY CHECKS
        public bool IsUsernameAvailable(string username)
        {
            return !IsUsernameTaken(username);
        }

        public bool IsEmailAvailable(string email)
        {
            return !IsEmailTaken(email);
        }

        public bool IsPhoneNumberAvailable(string phoneNumber)
        {
            return !IsPhoneNumberTaken(phoneNumber);
        }

        // ADD USER
        private void AddUser(User user)
        {
            User[] newUsers = new User[users.Length + 1];

            for (int i = 0; i < users.Length; i++)
            {
                newUsers[i] = users[i];
            }

            newUsers[newUsers.Length - 1] = user;

            users = newUsers;
        }

        // DUPLICATE CHECKS
        private bool IsUsernameTaken(string username)
        {
            foreach (User user in users)
            {
                if (user == null)
                    continue;

                if (string.Equals(
                    user.UserName,
                    username,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsEmailTaken(string email)
        {
            foreach (User user in users)
            {
                if (user == null)
                    continue;

                if (string.Equals(
                    user.Email,
                    email,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsPhoneNumberTaken(string phoneNumber)
        {
            string normalizedPhone = NormalizePhoneNumber(phoneNumber);

            foreach (User user in users)
            {
                if (user == null)
                    continue;

                string existingPhone =
                    NormalizePhoneNumber(user.PhoneNumber);

                if (string.Equals(
                    existingPhone,
                    normalizedPhone,
                    StringComparison.Ordinal))
                {
                    return true;
                }
            }

            return false;
        }

        private string NormalizePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return "";

            return phoneNumber
                .Replace(" ", "")
                .Replace("-", "")
                .Replace("+", "")
                .Replace("(", "")
                .Replace(")", "");
        }
    }
}