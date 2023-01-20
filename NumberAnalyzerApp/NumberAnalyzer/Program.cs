// See https://aka.ms/new-console-template for more information

bool bContinue = true;
String? UserAnswer = null;
bool IsSameUser = false;
string UserName = null;

do
{
    if (!IsSameUser)
    {
        Console.WriteLine("Please enter your Name:");
        UserName = Console.ReadLine();
        if (String.IsNullOrEmpty(UserName) || String.IsNullOrWhiteSpace(UserName) || UserName.Any(c => char.IsDigit(c)))
        {
            Console.WriteLine("Please enter a valid Name: Would you like to try again ? Say 'y' or 'n' ");
            UserAnswer = Console.ReadLine();
            if (UserAnswer.ToLower() == "n")
                break;
            else
                continue;
        }
    }
    Console.WriteLine($"Hi {UserName} - Please enter enter an integer between 1 and 100 ( inclusive of 1 and 100 )");
    string? Number = Console.ReadLine();
    bool validNum = int.TryParse(Number, out int ParsedInt);
    bool isOddNumber = true;
    string UserQuestion = $"Would you like to try again {UserName}?, Say 'y' or 'n'";


    if (!validNum || ParsedInt < 1 || ParsedInt > 100)
    {
        Console.WriteLine("Entered value either not a integer or in the range of 1 to 100. " + UserQuestion);
        string? UserInput = Console.ReadLine();
        CheckUserPreference(UserInput);
        continue;

    }

    if (ParsedInt % 2 == 0)
    {
        isOddNumber = false;
    }

    if (ParsedInt < 60 && isOddNumber)
    {
        Console.WriteLine($"Number:{ParsedInt} is Odd and less than 60");
        ReadUserPreference();

    }
    else if (ParsedInt > 1 && ParsedInt < 25 && !isOddNumber)
    {
        Console.WriteLine($"Number:{ParsedInt} is Even and less than 25");
        ReadUserPreference();
    }

    else if (ParsedInt >= 26 && ParsedInt <= 60 && !isOddNumber)
    {
        Console.WriteLine($"Number:{ParsedInt} is Even and between 26 and 60 inclusive");
        ReadUserPreference();
    }

    else if (ParsedInt > 60 && !isOddNumber)
    {
        Console.WriteLine($"Number:{ParsedInt} is Even and greater than 60");
        ReadUserPreference();
    }

    else if (ParsedInt > 60 && isOddNumber)
    {
        Console.WriteLine($"Number:{ParsedInt} is Odd and greater than 60");
        ReadUserPreference();
    }

    else
    {
        Console.WriteLine("The Number entered doesn't seem to fall in one of the categories");
        ReadUserPreference();
    }

    void ReadUserPreference()
    {
        Console.WriteLine(UserQuestion);
        string? ReadVal = Console.ReadLine();
        CheckUserPreference(ReadVal);
    }

    string CheckUserPreference(string userVal)
    {
        if (userVal != null)
        {
            if (userVal.ToLower() == "y")
            {
                bContinue = true;
                IsSameUser = true;

            }
            else
                bContinue = false;
        }
        else
            bContinue = false;
        return "";
    }

} while (bContinue);



