using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public class Input
    {
        private ConsoleKeyInfo answer;
        private string userAnswer;
        public string GetAnswer()
        {
            do
            {
                answer = Console.ReadKey(true);
            } while (answer.Key != ConsoleKey.Y && answer.Key != ConsoleKey.N);

            userAnswer = answer.KeyChar.ToString();
            Console.Write(userAnswer + "\n");

            return userAnswer.ToUpper();
        }
    }
}
