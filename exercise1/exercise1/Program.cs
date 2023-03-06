// علی حسنی - Ali Hassani
// This is a program which determine whether a number is a kind of *mirror number or not.
/* *mirror number is a number that if you read it either from left to right or
right to left it will be the same, like 12321 or 343 */


int inputNumber = Convert.ToInt32(Console.ReadLine());
int t;
int mirrorNumber = 0;
int firstNumber = inputNumber;


do
{
    t = inputNumber % 10;
    mirrorNumber = (mirrorNumber * 10) + t;
    inputNumber /= 10;
} while (inputNumber != 0);

if (mirrorNumber == firstNumber)
{
    Console.WriteLine("Mirror number");
}
else
{
    Console.WriteLine("Not mirror number");
}
