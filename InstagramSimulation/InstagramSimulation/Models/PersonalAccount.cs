

namespace InstagramSimulation.Models
{
    internal class PersonalAccount : User
    {
        public PersonalAccount(
            int id,
            string name,
            string surname,
            string username,
            string email,
            string phoneNumber,
            string password,
            DateTime birthDate,
            string bio,
            bool isPrivate,
            string profilePhoto) : base(id, name, surname, username, email, phoneNumber, password, birthDate)
        {
            Bio = bio;
            IsPrivate = isPrivate;
            ProfilePhoto = profilePhoto;
        }

        public string Bio { get; private set; }
        public bool IsPrivate { get; private set; }
        public string ProfilePhoto { get; private set; }

        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Personal Account.");
        }

        public void TogglePrivacy()
        {
            IsPrivate = !IsPrivate;
            Console.WriteLine($"Account privacy set to: {(IsPrivate ? "Private" : "Public")}");
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine($"Bio: {Bio}");
            Console.WriteLine($"Privacy: {(IsPrivate ? "Private" : "Public")}");
            Console.WriteLine($"Profile Photo: {ProfilePhoto}");
        }
    }
}
