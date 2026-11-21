
using InstagramSimulation.Helpers;

namespace InstagramSimulation.Models
{
    internal abstract class User
    {
        protected User(
            int id,
            string name,
            string surname,
            string username,
            string email,
            string phoneNumber,
            string password,
            DateTime birthDate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            UserName = username;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now;
        }

        public int Id { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string UserName { get; private set; }

        public string Email { get; private set; }

        public string PhoneNumber { get; private set; }

        private string Password { get; set; }

        public DateTime BirthDate { get; private set; }

        public virtual void DisplayProfile()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Username: {UserName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Birthday: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Age: {GetAge()}");
        }

        public void ChangeUsername(string newUsername)
        {
            if (!ValidationHelper.IsValidUsername(newUsername))
            {
                Console.WriteLine("Username formati duzgun deyil!");
                return;
            }

            UserName = newUsername;

            Console.WriteLine($"Username changed to: {UserName}");
        }

        public void ChangePassword(string newPassword)
        {
            string passwordError =
                ValidationHelper.GetPasswordValidationError(newPassword);

            if (!string.IsNullOrEmpty(passwordError))
            {
                Console.WriteLine(passwordError);
                return;
            }

            Password = newPassword;

            Console.WriteLine("Password changed successfully.");
        }

        public int GetAge()
        {
            var today = DateTime.Today;

            var age = today.Year - BirthDate.Year;

            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Created At: {CreatedAt}");
            Console.WriteLine($"User ID: {Id}");
        }

        public string GetPasswordValidationError()
        {
            return ValidationHelper.GetPasswordValidationError(Password);
        }

        // Login zamanı istifadə ediləcək.
        // Password-un özünü başqa class-a göstərmir.
        public bool VerifyPassword(string password)
        {
            return Password == password;
        }

        public abstract void DisplayAccountType();
    }
}
