// علی  حسنی - Ali Hassani
/*This program gets a number as a score and returns a grade based on that score
 and at the end converts it to a percentage*/




//Getting the student's score
int x;
Console.Write("Enter a student's score from 0 to 20: ");
x = Convert.ToInt32(Console.ReadLine());

//Check the score whether is between the valid range (0 to 20)
while (x < 0 || x > 20)
{
    Console.Write("The score is not valid. Please enter a score from 0 to 20: ");
    x = Convert.ToInt32(Console.ReadLine());
}
//Giving the student grade based on the score entered
if (x > 17 && x <= 20)
{
    Console.WriteLine("\nThe student's grade is: 'A'. \n");
}
else if (x >= 15 && x <= 17)
{
    Console.WriteLine("\nThe student's grade is: 'B'. \n");
}
else if (x >= 10 && x < 15)
{
    Console.WriteLine("\nThe student's grade is: 'C'. \n");
}
else if (x >= 0 && x < 10)
{
    Console.WriteLine("\nUnfortunately the student is 'failed'. \n");
}

//Converting the student's grade to percent
int p = x * 5;
Console.WriteLine($"Also the student's percent is : {p}%");