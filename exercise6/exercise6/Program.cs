//علی حسنی - Ali Hassani
/* This program asks a question from user and then provide
 another specific questions based on the user previous answer */

using exercise6;

Input input = new();
QuestionFoodHandler handler = new();

do
{
    Console.WriteLine("Answer questions below by y(yes) or n(no).");
    Console.Write(handler.QuestionsList[0]);
    switch (input.GetAnswer())
    {
        case "Y":
            handler.FastFoodCheck();
            break;
        case "N":
            handler.TraditionalCheck();
            break;
    }
} while (input.GetAnswer() == "Y");
Console.WriteLine("GoodBye");


