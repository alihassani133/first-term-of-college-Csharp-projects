// علی حسنی - Ali Hassani
/*This program check if a number is prime or not*/

bool IsPrime = true;
int number;
do
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number <= 1)
    {
        Console.WriteLine("Invalid number, enter another: ");
    }
} while (number <= 1);

for (int i = 2; (i <= (number / 2) && IsPrime); i++)
{
    if (number % i == 0)
    {
        IsPrime = false;
    }
}
if (IsPrime)
{
    Console.WriteLine("It is a prime number.");
}
else
{
    Console.WriteLine("It is not a prime number.");
}
