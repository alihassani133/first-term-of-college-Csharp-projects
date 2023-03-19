// علی حسنی - Ali Hassani
/*This program reads a csv file and do some processes on it*/

using Exercise7_DataAnalysis.Model;
using Exercise7_DataAnalysis.Operation;

UserInterface userInterface = new();

string file = userInterface.ChoosingCsvFile();

DataSetContext dataSetContext = new(file);
userInterface.Done();
userInterface.ClearConsoleInfo();
Processor processor = new(dataSetContext.Orders);

do
{
    switch (userInterface.ChoosingProcess())
    {
        case "1":
            Console.Write("\nEnter a year: ");
            int year = userInterface.ControlProcessorsInput();
            long totalSalesOfYear = processor.TotalSalesByYear(year);
            Console.WriteLine(totalSalesOfYear == 0 ? "\nNo sale in this year" : "\nThe total sales amount is " + totalSalesOfYear); 
            break;
        case "2":
            Console.Write("\nEnter a month: ");
            int month = userInterface.ControlProcessorsInput();
            long totalSalesOfMonth = processor.TotalSalesByMonth(month);
            Console.WriteLine(totalSalesOfMonth == 0 ? "\nInvalid month" : "\nThe total sales amount is " + totalSalesOfMonth);
            break;
        case "3":
            Console.Write("\nEnter an item id: ");
            int itemId = userInterface.ControlProcessorsInput();
            long totalSalesOfItem = processor.TotalSalesByItem(itemId);
            Console.WriteLine(totalSalesOfItem == 0 ? "\nNo sale of this item" : "\nThe total sales amount is " + totalSalesOfItem);
            break;
        case "4":
            Console.Write("\nEnter a customer id: ");
            int customerId = userInterface.ControlProcessorsInput();
            long totalPurchaseOfCustomer = processor.TotalSalesByCustomer(customerId);
            Console.WriteLine(totalPurchaseOfCustomer == 0 ? "\nNo purchase from this customer" : "\nThe total purchase amount is " + totalPurchaseOfCustomer);
            break;
        case "5":
            string filePath = userInterface.InputFilePath();
            userInterface.Waiting();
            processor.SepareteEachCityOrders(filePath);
            userInterface.Done();
            break;
    }
} while (userInterface.RepeatProcess());