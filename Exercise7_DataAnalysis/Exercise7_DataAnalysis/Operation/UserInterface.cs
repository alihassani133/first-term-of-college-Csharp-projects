using System.Net;
using System.IO;

namespace Exercise7_DataAnalysis.Operation
{
    class UserInterface
    {
        public string ChoosingProcess()
        {
            string[] inputs = { "1", "2", "3", "4", "5" };
            Console.WriteLine("What do you want to do? choose:");
            Console.WriteLine("To get the total sales of a specific year, press '1'");
            Console.WriteLine("To get the total sales of a specific month, press '2'");
            Console.WriteLine("To get the total sales of a specific item, press '3'");
            Console.WriteLine("To get the total purchase of a specific customer, press '4'");
            Console.WriteLine("To get each city's related orders in separated files, press '5'");
            Console.Write("Which process do want to do?: ");
            return ControlUserInput(inputs);
        }
        public void ClearConsoleInfo()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void Waiting()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPlease wait...");
            Console.ResetColor();
        }
        public void Done()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nProcess done!");
            Console.ResetColor();
        }
        public string ChoosingCsvFile()
        {
            string[] inputs = { "1", "2" };
            string tempFile = "";
            Console.WriteLine("This program automatically can download" +
            " the Digikala dataset csv file. \nBut if you have this file" +
            " in your pc, you can give it's path.");
            Console.Write("So you can let the program download it" +
            " by pressing number 1 on keybourd, or you can give the file path\n" +
            "manually by pressing number 2 on keyboard: ");
            switch (ControlUserInput(inputs))
            {
                case "1":
                    Waiting();
                    string url = "http://alihafezi.com/fa/wp-content/uploads/2023/03/orders.csv";
                    WebClient webClient = new();
                    tempFile = Path.GetTempFileName();
                    webClient.DownloadFile(url, tempFile);
                    break;
                case "2":
                    do
                    {
                        Console.WriteLine("Enter a valid csv file path: ");
                        tempFile = Console.ReadLine();
                    } while (!File.Exists(tempFile) &&
                    !Path.GetExtension(tempFile).Equals(".csv", StringComparison.OrdinalIgnoreCase));
                    Waiting();
                    break;
            }
            return tempFile;
        }
        public string ControlUserInput(string[] values)
        {
            bool isValid = false;
            ConsoleKeyInfo firstInput;
            do
            {
                firstInput = Console.ReadKey(true);
                foreach (var item in values)
                {
                    if (item.ToLower() == firstInput.KeyChar.ToString().ToLower())
                    {
                        isValid = true;
                    }
                }
            } while (isValid == false);
            string finalInput = firstInput.KeyChar.ToString();
            Console.WriteLine(finalInput);
            return finalInput;
        }
        public bool RepeatProcess()
        {
            Console.WriteLine("\nWould you want to do another process?\n" +
                "If yes press 'y' if no press 'n'");
            string[] inputs = { "y", "n" };
            if (ControlUserInput(inputs) == "y")
            {
                ClearConsoleInfo();
                return true;
            }
            else
            {
                ClearConsoleInfo();
                Console.WriteLine("Goodbye!!");
                return false;
            }
        }
        public int ControlProcessorsInput()
        {
            ConsoleKeyInfo input;
            string finalValue = "";
            do
            {
                input = Console.ReadKey(true);
                if (Char.IsDigit(input.KeyChar))
                {
                    Console.Write(input.KeyChar);
                    finalValue += input.KeyChar;
                }
            } while (input.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return Convert.ToInt32(finalValue);
        }
        public string InputFilePath()
        {
            string filePath;
            do
            {
                Console.WriteLine("Enter an available and valid file path to putting the files created in it:");
                filePath = Console.ReadLine();
            } while (!Directory.Exists($@"{filePath}"));
            return filePath;
        }
    }
}
