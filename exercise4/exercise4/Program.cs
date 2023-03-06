// علی حسنی - Ali Hassani
/*This program gets two numbers and print all the prime numbers between them.*/


int m, n;
int x, y;
bool IsPrime;
bool IsValid;
List<int> PrimeNumbers = new();

Console.WriteLine("Enter two numbers to check and print the prime numbers between them:");

//Checking the numbers whether they are valid or not
do
{
    IsValid = true;
    m = Convert.ToInt32(Console.ReadLine());
    n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || n < 0)
    {
        Console.WriteLine("You cannot enter negative numbers; try again:");
        IsValid = false;
    }
} while (!IsValid);

//Sorting the entered numbers
if (m > n)
{
    x = m;
    y = n;
}
else
{
    x = n;
    y = m;
}

//Finding the prime numbers
for (int i = y; i <= x;)
{
    if (i < 2)
    {
        i++;
        continue;
    }
    for (int c = 2; c < i;)
    {
        if (i % c != 0)
        {
            c++;
        }
        else
        {
            IsPrime = false;
            goto ListTheNumbers;
        }
    }
    IsPrime = true;
ListTheNumbers:
    if (IsPrime != false)
    {
        PrimeNumbers.Add(i);
    }
    i++;
}

//Printing the prime numbers if they exist
if (PrimeNumbers.Count == 0)
{
    Console.WriteLine($"No prime number in the range between {x} and {y}");
}
else
{
    Console.WriteLine("Prime numbers in this range: ");
    foreach (var item in PrimeNumbers)
    {
        Console.WriteLine(item);
    }
}