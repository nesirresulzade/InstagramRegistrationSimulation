
using InstagramSimulation.Helpers;
using InstagramSimulation.Models;
using InstagramSimulation.Services;
using System.Globalization;

User[] users = new User[0];

RegistrationService registrationService =
    new RegistrationService(users);

bool continueRegistration = true;

while (continueRegistration)
{
    Console.WriteLine("\n===== INSTAGRAM SIMULATION =====");
    Console.WriteLine("1. Personal Account");
    Console.WriteLine("2. Business Account");

    Console.Write("Account type seçin: ");
    string choice = Console.ReadLine() ?? "";

    int id = registrationService.Users.Length + 1;

    if (choice == "1")
    {
        Console.WriteLine("\n===== PERSONAL ACCOUNT REGISTRATION =====");

        string name;

        while (true)
        {
            Console.Write("Name: ");
            name = Console.ReadLine() ?? "";

            if (ValidationHelper.IsValidName(name))
                break;

            Console.WriteLine("Ad düzgün formatda deyil!\n");
        }

        string surname;

        while (true)
        {
            Console.Write("Surname: ");
            surname = Console.ReadLine() ?? "";

            if (ValidationHelper.IsValidName(surname))
                break;

            Console.WriteLine("Soyad düzgün formatda deyil!\n");
        }

        string username;

        while (true)
        {
            Console.Write("Username: ");
            username = (Console.ReadLine() ?? "").Trim();

            if (!ValidationHelper.IsValidUsername(username))
            {
                Console.WriteLine("Username formatı düzgün deyil!");
                continue;
            }

            if (!registrationService.IsUsernameAvailable(username))
            {
                Console.WriteLine("Bu username artıq istifadə olunur!");
                continue;
            }

            break;
        }

        string email;

        while (true)
        {
            Console.Write("Email: ");
            email = (Console.ReadLine() ?? "").Trim();

            if (!ValidationHelper.IsValidEmail(email))
            {
                Console.WriteLine("Email formatı düzgün deyil!\n");
                continue;
            }

            if (!registrationService.IsEmailAvailable(email))
            {
                Console.WriteLine("Bu email artıq qeydiyyatdan keçib!\n");
                continue;
            }

            break;
        }

        string password;

        while (true)
        {
            Console.Write("Password: ");
            password = Console.ReadLine() ?? "";

            string error =
                ValidationHelper.GetPasswordValidationError(password);

            if (error == "")
                break;

            Console.WriteLine(error);
            Console.WriteLine("Yenidən cəhd edin.\n");
        }

        string phoneNumber;

        while (true)
        {
            Console.Write("Phone Number: ");
            phoneNumber = (Console.ReadLine() ?? "").Trim();

            if (!ValidationHelper.IsValidPhoneNumber(phoneNumber))
            {
                Console.WriteLine("Telefon nömrəsi düzgün deyil!\n");
                continue;
            }

            if (!registrationService.IsPhoneNumberAvailable(phoneNumber))
            {
                Console.WriteLine("Bu telefon nömrəsi artıq istifadə olunur!\n");
                continue;
            }

            break;
        }

        DateTime birthDate;

        while (true)
        {
            Console.Write("Birth Date (yyyy-MM-dd): ");
            string input = Console.ReadLine() ?? "";

            if (!DateTime.TryParseExact(
                input,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out birthDate))
            {
                Console.WriteLine("Tarix formatı yanlışdır!\n");
                continue;
            }

            string error =
                ValidationHelper.GetBirthDateValidationError(birthDate);

            if (error == "")
                break;

            Console.WriteLine(error);
        }

        string bio;

        while (true)
        {
            Console.Write("Bio: ");
            bio = Console.ReadLine() ?? "";

            if (bio.Length <= 150)
                break;

            Console.WriteLine("Bio maksimum 150 simvol ola bilər!\n");
        }

        bool isPrivate;

        while (true)
        {
            Console.Write("Is Private? (true/false): ");
            string input = Console.ReadLine() ?? "";

            if (bool.TryParse(input, out isPrivate))
                break;

            Console.WriteLine("Yalnız true və ya false daxil edin!\n");
        }

        string profilePhoto;

        while (true)
        {
            Console.Write("Profile Photo URL (optional): ");
            profilePhoto = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(profilePhoto))
                break;

            if (Uri.TryCreate(
                profilePhoto,
                UriKind.Absolute,
                out Uri? uri) &&
                (uri.Scheme == Uri.UriSchemeHttp ||
                 uri.Scheme == Uri.UriSchemeHttps))
            {
                break;
            }

            Console.WriteLine("Düzgün URL daxil edin!\n");
        }

        PersonalAccount account = new PersonalAccount(
            id,
            name,
            surname,
            username,
            email,
            phoneNumber,
            password,
            birthDate,
            bio,
            isPrivate,
            profilePhoto
        );

        registrationService.RegisterPersonalAccount(account);
    }
    else if (choice == "2")
    {
        Console.WriteLine("\n===== BUSINESS ACCOUNT REGISTRATION =====");

        string name;

        while (true)
        {
            Console.Write("Name: ");
            name = Console.ReadLine() ?? "";

            if (ValidationHelper.IsValidName(name))
                break;

            Console.WriteLine("Ad düzgün formatda deyil!\n");
        }

        string surname;

        while (true)
        {
            Console.Write("Surname: ");
            surname = Console.ReadLine() ?? "";

            if (ValidationHelper.IsValidName(surname))
                break;

            Console.WriteLine("Soyad düzgün formatda deyil!\n");
        }

        string username;

        while (true)
        {
            Console.Write("Username: ");
            username = (Console.ReadLine() ?? "").Trim();

            if (!ValidationHelper.IsValidUsername(username))
            {
                Console.WriteLine("Username formatı düzgün deyil!");
                continue;
            }

            if (!registrationService.IsUsernameAvailable(username))
            {
                Console.WriteLine("Bu username artıq istifadə olunur!");
                continue;
            }

            break;
        }

        string email;

        while (true)
        {
            Console.Write("Email: ");
            email = (Console.ReadLine() ?? "").Trim();

            if (!ValidationHelper.IsValidEmail(email))
            {
                Console.WriteLine("Email formatı düzgün deyil!\n");
                continue;
            }

            if (!registrationService.IsEmailAvailable(email))
            {
                Console.WriteLine("Bu email artıq qeydiyyatdan keçib!\n");
                continue;
            }

            break;
        }

        string password;

        while (true)
        {
            Console.Write("Password: ");
            password = Console.ReadLine() ?? "";

            string error =
                ValidationHelper.GetPasswordValidationError(password);

            if (error == "")
                break;

            Console.WriteLine(error);
            Console.WriteLine("Yenidən cəhd edin.\n");
        }

        string phoneNumber;

        while (true)
        {
            Console.Write("Phone Number: ");
            phoneNumber = (Console.ReadLine() ?? "").Trim();

            if (!ValidationHelper.IsValidPhoneNumber(phoneNumber))
            {
                Console.WriteLine("Telefon nömrəsi düzgün deyil!\n");
                continue;
            }

            if (!registrationService.IsPhoneNumberAvailable(phoneNumber))
            {
                Console.WriteLine("Bu telefon nömrəsi artıq istifadə olunur!\n");
                continue;
            }

            break;
        }

        DateTime birthDate;

        while (true)
        {
            Console.Write("Birth Date (yyyy-MM-dd): ");
            string input = Console.ReadLine() ?? "";

            if (!DateTime.TryParseExact(
                input,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out birthDate))
            {
                Console.WriteLine("Tarix formatı yanlışdır!\n");
                continue;
            }

            string error =
                ValidationHelper.GetBirthDateValidationError(birthDate);

            if (error == "")
                break;

            Console.WriteLine(error);
        }

        string businessName;

        while (true)
        {
            Console.Write("Business Name: ");
            businessName = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(businessName))
                break;

            Console.WriteLine("Business Name boş ola bilməz!\n");
        }

        string businessCategory;

        while (true)
        {
            Console.Write("Business Category: ");
            businessCategory = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(businessCategory))
                break;

            Console.WriteLine("Business Category boş ola bilməz!\n");
        }

        string website;

        while (true)
        {
            Console.Write("Website (optional): ");
            website = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(website))
                break;

            if (Uri.TryCreate(
                website,
                UriKind.Absolute,
                out Uri? uri) &&
                (uri.Scheme == Uri.UriSchemeHttp ||
                 uri.Scheme == Uri.UriSchemeHttps))
            {
                break;
            }

            Console.WriteLine("Düzgün Website URL daxil edin!\n");
        }

        BusinessAccount businessAccount = new BusinessAccount(
            id,
            name,
            surname,
            username,
            email,
            phoneNumber,
            password,
            birthDate,
            businessName,
            businessCategory,
            website
        );

        registrationService.RegisterBusinessAccount(businessAccount);
    }
    else
    {
        Console.WriteLine("Yanlış seçim!");
        continue;
    }

    Console.Write("\nYeni user əlavə etmək istəyirsiniz? (yes/no): ");

    string answer = (Console.ReadLine() ?? "")
        .Trim()
        .ToLower();

    if (answer != "yes" && answer != "y")
    {
        continueRegistration = false;
    }
}

// Array-i RegistrationService-dən əldə edirik
users = registrationService.Users;

Console.WriteLine("\n===== REGISTERED USERS =====");

for (int i = 0; i < users.Length; i++)
{
    Console.WriteLine($"\n===== USER #{i + 1} =====");

    users[i].DisplayAccountType();
    users[i].DisplayProfile();
}

Console.WriteLine("\nProqram başa çatdı.");
