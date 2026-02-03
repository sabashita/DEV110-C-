namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        Console.WriteLine("What's your name? ");
        string _fullName = Console.ReadLine();
        // - Hometown (city, state)
        Console.WriteLine("where is your hometown? ");
        string _homeTown = Console.ReadLine();
        // - Favorite color
        Console.WriteLine("What's your favorite color? ");
        string _favoriteColor = Console.ReadLine();
        // - Dream job
        Console.WriteLine("What's your dream job? ");
        string _dreamJob = Console.ReadLine();

        // Hint: string variableName = Console.ReadLine();

        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        Console.WriteLine("What's your Major? ");
        string _major = Console.ReadLine();

        // - GPA (double, 0.0-4.0)
        Console.WriteLine("How's your gpa? ");
        double _gpa = double.Parse(Console.ReadLine());

        // - Graduation year (int)
        Console.WriteLine("What's your graduate year or expected? ");
        int _gdYear = int.Parse(Console.ReadLine());

        // - Is full-time student? (bool from yes/no)
        Console.WriteLine("Are you a full-time student? ");
        bool _isFTstudent = Console.ReadLine().ToLower() == "yes";

        // Hint: double gpa = double.Parse(Console.ReadLine());

        // Hint: bool isFullTime = answer.ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        Console.WriteLine("May I have your age?");
        int _age = int.Parse(Console.ReadLine());
        // - Height in inches (double)
        Console.WriteLine("What is your height? (cm))");
        double _height = double.Parse(Console.ReadLine());
        // - Favorite number (int)
        Console.WriteLine("What is your favorite number?");
        int _fNumber = int.Parse(Console.ReadLine());

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        int _birthYear = DateTime.Now.Year - _age;

        // - Years to graduation = graduationYear - 2026
        int _yearToGd = _gdYear - DateTime.Now.Year;
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        double _heightInFeet = Math.Round(_height / 30.48, 2);
        double _heightInInch = Math.Round(_height / 2.54, 2);

        // - Is honor student? = gpa >= 3.5
        bool _isHonor = _gpa >= 3.5;
        // - Age in months = age * 12
        int _ageInMon = _age * 12;

        // TODO: DISPLAY formatted profile card
        //     Use sections with headers:
        //     -PERSONAL INFORMATION
        //     - ACADEMIC DETAILS
        //     - CALCULATED STATISTICS
        //     Use proper alignment and formatting

        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");
        Console.WriteLine("\n════════════Personal Information═══════════");
        Console.WriteLine($"Name:                          | {_fullName}");
        Console.WriteLine($"Hometown:                      | {_homeTown}");
        Console.WriteLine($"Age:                           | {_age}");
        Console.WriteLine($"Age in month:                  | {_ageInMon}");
        Console.WriteLine($"Height:                        | {_height}");
        Console.WriteLine($"BirthYear:                     | {_birthYear}");
        Console.WriteLine("\n════════════Academic Information═══════════");
        Console.WriteLine($"Major:                         | {_major}");
        Console.WriteLine($"GPA:                           | {_gpa:F2}");
        Console.WriteLine($"Graduation year:               | {_gdYear}");
        Console.WriteLine($"Full-time student:             | {_isFTstudent}");
        Console.WriteLine($"Honor student:                 | {_isHonor}");
        Console.WriteLine("\n════════════Additional Details═════════════");
        Console.WriteLine($"Favorite Color:                | {_favoriteColor}");
        Console.WriteLine($"Dream job:                     | {_dreamJob}");
        Console.WriteLine($"Year To granduate:             | {_yearToGd}");
        Console.WriteLine($"Height in feet:                | {_heightInFeet}");
        Console.WriteLine($"Height in inches:              | {_heightInInch}");
        Console.WriteLine($"FavoriteNumber:                | {_fNumber}");


        Console.WriteLine("\n════════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
