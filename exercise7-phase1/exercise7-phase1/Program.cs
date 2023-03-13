// علی حسنی - Ali Hassani
/*This program downloads a csv file that has several columns. It's a Shop dataset 
that has the data of orders that customers did during several years. This program downloads
it then filters the orders based on city of orders and the year of the orders and
write each city and each year orders into specific files*/

using System.Net;
using System.Text;
using File = System.IO.File;

//Download the file from the site
string url = "http://alihafezi.com/fa/wp-content/uploads/2023/03/orders.csv";
WebClient webClient = new();
string tempFile = Path.GetTempFileName();
webClient.DownloadFile(url, tempFile);

//Choose a directory of your local drives
string cityFilesPath = @"E:\Csharp Projects\College\برنامه‌سازی پیشرفته 1\exercise7-phase1\filesGenerated\CityBased\";
string yearFilesPath = @"E:\Csharp Projects\College\برنامه‌سازی پیشرفته 1\exercise7-phase1\filesGenerated\YearBased\";

//Calling Methods
FilterByCity();
FilterByYear();

//Deleting downloaded file after using it
File.Delete(tempFile);

//Methods
void FilterByYear()
{
    using (StreamReader reader1 = new(tempFile))
    {
        string lineReader1;
        string time;
        string year;

        reader1.ReadLine();

        do
        {
            StreamReader reader2 = new(tempFile);
            lineReader1 = reader1.ReadLine();
            string[] lineReader1Columns = lineReader1.Split(",");
            time = lineReader1Columns[3];
            year = time.Substring(0,4);
            if (!File.Exists(yearFilesPath + year + ".csv"))
            {
                StreamWriter writer = new(yearFilesPath + year + ".csv", false, Encoding.UTF8);
                while (!reader2.EndOfStream)
                {
                    string lineReader2 = reader2.ReadLine();
                    string[] lineReader2Columns = lineReader2.Split(",");
                    if (lineReader2Columns[3].Substring(0,4).Contains(year))
                    {
                        writer.WriteLine(lineReader2);
                    }
                }
                writer.Dispose();
            }
            reader2.Dispose();
        } while (!reader1.EndOfStream);
    }
    Console.WriteLine("filtering by year is done!");
}
void FilterByCity()
{
    using (StreamReader reader1 = new(tempFile))
    {
        string lineReader1;
        string city;

        reader1.ReadLine();

        do
        {
            StreamReader reader2 = new(tempFile);
            lineReader1 = reader1.ReadLine();
            string[] lineReader1Columns = lineReader1.Split(",");
            city = lineReader1Columns[5];
            if (!File.Exists(cityFilesPath + city + ".csv"))
            {
                StreamWriter writer = new(cityFilesPath + city + ".csv", false, Encoding.UTF8);
                while (!reader2.EndOfStream)
                {
                    string lineReader2 = reader2.ReadLine();
                    if (lineReader2.Contains(city))
                    {
                        string[] lineReader2Columns = lineReader2.Split(",");
                        if (lineReader2Columns[5] == city)
                        {
                            writer.WriteLine(lineReader2);
                        }
                    }
                }
                writer.Dispose();
            }
            reader2.Dispose();
        } while (!reader1.EndOfStream);
    }
    Console.WriteLine("filtering by city is done!");
}

