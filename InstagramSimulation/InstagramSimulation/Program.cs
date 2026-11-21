
using InstagramSimulation.Helpers;
using InstagramSimulation.Models;
using InstagramSimulation.Services;
using System.Globalization;

List<User> users = new List<User>();

RegistrationService registrationService =
    new RegistrationService(users);

#region Personal account qeydiyyati
//Console.WriteLine("===== INSTAGRAM SIMULATION =====");
//Console.WriteLine("===== PERSONAL ACCOUNT REGISTRATION =====");

//string name;

//while (true)
//{
//    Console.Write("Name: ");
//    name = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidName(name))
//        break;

//    Console.WriteLine("Ad duzgun formatda deyil! Yenidun daxil edin.\n");
//}

//string surname;

//while (true)
//{
//    Console.Write("Surname: ");
//    surname = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidName(surname))
//        break;

//    Console.WriteLine("Soyad duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//string username;

//while (true)
//{
//    Console.Write("Username: ");
//    username = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidUsername(username))
//        break;

//    Console.WriteLine("Username duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//string email;

//while (true)
//{
//    Console.Write("Email: ");
//    email = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidEmail(email))
//        break;

//    Console.WriteLine("Email duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//string password;

//while (true)
//{
//    Console.Write("Password: ");
//    password = Console.ReadLine() ?? "";

//    string error = ValidationHelper.GetPasswordValidationError(password);

//    if (error == "")
//        break;

//    Console.WriteLine(error);
//    Console.WriteLine("Zehmet olmasa, yeniden cehd edin.\n");
//}

//string phoneNumber;

//while (true)
//{
//    Console.Write("Phone Number: ");
//    phoneNumber = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidPhoneNumber(phoneNumber))
//        break;

//    Console.WriteLine("Telefon nomresi duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//DateTime birthDate;

//while (true)
//{
//    Console.Write("Birth Date (yyyy-MM-dd): ");
//    string input = Console.ReadLine() ?? "";

//    if (!DateTime.TryParseExact(
//        input,
//        "yyyy-MM-dd",
//        CultureInfo.InvariantCulture,
//        DateTimeStyles.None,
//        out birthDate))
//    {
//        Console.WriteLine("Tarix formati yanlisdir! Yeniden daxil edin.\n");
//        continue;
//    }

//    string error = ValidationHelper.GetBirthDateValidationError(birthDate);

//    if (error == "")
//        break;

//    Console.WriteLine(error);
//    Console.WriteLine("Yeniden daxil edin.\n");
//}

//string bio;

//while (true)
//{
//    Console.Write("Bio: ");
//    bio = Console.ReadLine() ?? "";

//    if (bio.Length <= 150)
//        break;

//    Console.WriteLine("Bio maksimum 150 simvol ola biler! Yeniden daxil edin.\n");
//}

//bool isPrivate;

//while (true)
//{
//    Console.Write("Is Private? (true/false): ");
//    string input = Console.ReadLine() ?? "";

//    if (bool.TryParse(input, out isPrivate))
//        break;

//    Console.WriteLine("Yalniz true ve ya false daxil edin!\n");
//}

//string profilePhoto;

//while (true)
//{
//    Console.Write("Profile Photo URL: ");
//    profilePhoto = Console.ReadLine() ?? "";

//    if (string.IsNullOrWhiteSpace(profilePhoto))
//        break;

//    if (Uri.TryCreate(
//        profilePhoto,
//        UriKind.Absolute,
//        out Uri? uri) &&
//        (uri.Scheme == Uri.UriSchemeHttp ||
//         uri.Scheme == Uri.UriSchemeHttps))
//    {
//        break;
//    }

//    Console.WriteLine("Duzgün URL daxil edin! Yeniden cehd edin.\n");
//}

//PersonalAccount account = new PersonalAccount(
//    1,
//    name,
//    surname,
//    username,
//    email,
//    phoneNumber,
//    password,
//    birthDate,
//    bio,
//    isPrivate,
//    profilePhoto
//);

//registrationService.RegisterPersonalAccount(account);
#endregion


#region Bizness account qeydiyyati
//Console.WriteLine("===== INSTAGRAM SIMULATION =====");
//Console.WriteLine("===== BUSINESS ACCOUNT REGISTRATION =====");

//// NAME
//string name;

//while (true)
//{
//    Console.Write("Name: ");
//    name = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidName(name))
//        break;

//    Console.WriteLine("Ad duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//// SURNAME
//string surname;

//while (true)
//{
//    Console.Write("Surname: ");
//    surname = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidName(surname))
//        break;

//    Console.WriteLine("Soyad duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//// USERNAME
//string username;

//while (true)
//{
//    Console.Write("Username: ");
//    username = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidUsername(username))
//        break;

//    Console.WriteLine("Username duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//// EMAIL
//string email;

//while (true)
//{
//    Console.Write("Email: ");
//    email = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidEmail(email))
//        break;

//    Console.WriteLine("Email duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//// PASSWORD
//string password;

//while (true)
//{
//    Console.Write("Password: ");
//    password = Console.ReadLine() ?? "";

//    string error = ValidationHelper.GetPasswordValidationError(password);

//    if (error == "")
//        break;

//    Console.WriteLine(error);
//    Console.WriteLine("Yeniden cehd edin.\n");
//}

//// PHONE NUMBER
//string phoneNumber;

//while (true)
//{
//    Console.Write("Phone Number: ");
//    phoneNumber = Console.ReadLine() ?? "";

//    if (ValidationHelper.IsValidPhoneNumber(phoneNumber))
//        break;

//    Console.WriteLine("Telefon nomresi duzgun formatda deyil! Yeniden daxil edin.\n");
//}

//// BIRTH DATE
//DateTime birthDate;

//while (true)
//{
//    Console.Write("Birth Date (yyyy-MM-dd): ");
//    string input = Console.ReadLine() ?? "";

//    if (!DateTime.TryParseExact(
//        input,
//        "yyyy-MM-dd",
//        CultureInfo.InvariantCulture,
//        DateTimeStyles.None,
//        out birthDate))
//    {
//        Console.WriteLine("Tarix formati yanlisdir! Yeniden daxil edin.\n");
//        continue;
//    }

//    string error = ValidationHelper.GetBirthDateValidationError(birthDate);

//    if (error == "")
//        break;

//    Console.WriteLine(error);
//    Console.WriteLine("Yeniden daxil edin.\n");
//}

//// BUSINESS NAME
//string businessName;

//while (true)
//{
//    Console.Write("Business Name: ");
//    businessName = Console.ReadLine() ?? "";

//    if (!string.IsNullOrWhiteSpace(businessName))
//        break;

//    Console.WriteLine("Business Name bos ola bilmez! Yeniden daxil edin.\n");
//}

//// BUSINESS CATEGORY
//string businessCategory;

//while (true)
//{
//    Console.Write("Business Category: ");
//    businessCategory = Console.ReadLine() ?? "";

//    if (!string.IsNullOrWhiteSpace(businessCategory))
//        break;

//    Console.WriteLine("Business Category bos ola bilmez! Yeniden daxil edin.\n");
//}

//// WEBSITE
//string website;

//while (true)
//{
//    Console.Write("Website (optional): ");
//    website = Console.ReadLine() ?? "";

//    if (string.IsNullOrWhiteSpace(website))
//        break;

//    if (Uri.TryCreate(
//        website,
//        UriKind.Absolute,
//        out Uri? uri) &&
//        (uri.Scheme == Uri.UriSchemeHttp ||
//         uri.Scheme == Uri.UriSchemeHttps))
//    {
//        break;
//    }

//    Console.WriteLine("Duzgun Website URL daxil edin! Yeniden cehd edin.\n");
//}

//// CREATE BUSINESS ACCOUNT
//BusinessAccount businessAccount = new BusinessAccount(
//    2,
//    name,
//    surname,
//    username,
//    email,
//    phoneNumber,
//    password,
//    birthDate,
//    businessName,
//    businessCategory,
//    website
//);

//registrationService.RegisterBusinessAccount(businessAccount);
#endregion