// علی حسنی - Ali Hassani
/* This program gets a score and returns a grade based on it
 and at the end, converts it to a percentage. Also this program prevent the user from
entering characters instead of number*/
/* In this program I used methods to execute the instructions */

#region Variables
int score = 0;
ConsoleKeyInfo digits;
bool IsEnterKey;
bool IsContinued;
ConsoleKeyInfo answer;
#endregion

do
{
    Console.Write("Enter a score and press Enter to submit it: ");
    do
    {
        CheckDigits();
        PrintNumber();
    } while (!IsEnterKey);

    GradeScore();
    ScorePercentage();
} while (Continue());
Console.WriteLine("Goodbye!");

#region Methods
//Checking the digits of the number entered
void CheckDigits()
{
    do
    {
        digits = Console.ReadKey(true);
    } while (digits.KeyChar.ToString() != "0" && digits.KeyChar.ToString() != "1" &&
             digits.KeyChar.ToString() != "2" && digits.KeyChar.ToString() != "3" &&
             digits.KeyChar.ToString() != "4" && digits.KeyChar.ToString() != "5" &&
             digits.KeyChar.ToString() != "6" && digits.KeyChar.ToString() != "7" &&
             digits.KeyChar.ToString() != "8" && digits.KeyChar.ToString() != "9" &&
             digits.Key != ConsoleKey.Enter);
}
//Showing the number 
void PrintNumber()
{
    IsEnterKey = digits.Key == ConsoleKey.Enter;
    if (!IsEnterKey)
    {
        score = score * 10 + Convert.ToInt32(digits.KeyChar.ToString());
        Console.Write(digits.KeyChar);
    }
}
//Show the grade based on the score entered
void GradeScore()
{
    Console.WriteLine();
    switch (score)
    {
        case <= 20 and >= 17:
            Console.WriteLine("The grade is: A");
            break;
        case < 17 and >= 15:
            Console.WriteLine("The grade is: B");
            break;
        case < 15 and >= 10:
            Console.WriteLine("The grade is: C");
            break;
        case <= 10 and >= 0:
            Console.WriteLine("Failed");
            break;
        default:
            Console.WriteLine("Invalid Score");

            break;
    }
}
//Check if the user want to enter another number
bool Continue()
{
    Console.Write("Want to continue and add a new score to check?" + "\n" +
        "If yes press 'y', if no press'n': ");
    do
    {
        answer = Console.ReadKey(true);
    } while (answer.Key != ConsoleKey.Y && answer.Key != ConsoleKey.N);

    if (answer.Key == ConsoleKey.Y)
    {
        IsContinued = true;
    }
    else
    {
        IsContinued = false;
    }
    Console.WriteLine();
    score = 0;
    return IsContinued;
}
//Conveting the score to percentage
void ScorePercentage()
{
    if (score < 0 || score > 20)
    {
        Console.WriteLine("I can't give you a percentage based on an invalid number");
    }
    else
    {
        Console.WriteLine($"Percentage based on the score : {score * 5}%");
    }
}
#endregion