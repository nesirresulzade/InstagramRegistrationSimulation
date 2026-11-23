

namespace InstagramSimulation.Models
{
    internal class BusinessAccount : User
    {
        public BusinessAccount(
            int id,
            string name,
            string surname,
            string username,
            string email,
            string phoneNumber,
            string password,
            DateTime birthDate,
            string businessName,
            string businessCategory,
            string website) : base(id, name, surname, username, email, phoneNumber, password, birthDate)
        {
            BusinessName = businessName.Trim();
            BusinessCategory = businessCategory;
            Website = website;
        }

        public string BusinessName { get; private set; }
        public string BusinessCategory { get; private set; }
        public string Website { get; private set; }

        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Business Account.");
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            DisplayBusinessInfo();
        }

        public void DisplayBusinessInfo()
        {   
            Console.WriteLine($"Business Name: {BusinessName}");
            Console.WriteLine($"Business Category: {BusinessCategory}");
            Console.WriteLine($"Website: {Website}");
        }

        public void ChangeBusinessName(string newBusinessName)
        {
            if (string.IsNullOrWhiteSpace(newBusinessName))
            {
                Console.WriteLine("Business name cannot be empty.");
                return;
            }

            BusinessName = newBusinessName;
            Console.WriteLine($"Business name changed successfully to: {BusinessName}");
        }
    }
}
