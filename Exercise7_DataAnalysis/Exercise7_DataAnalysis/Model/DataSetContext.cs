using System;
using System.Collections.Concurrent;
using System.Numerics;
using System.Text;

namespace Exercise7_DataAnalysis.Model
{
    class DataSetContext
    {
        public List<Order> Orders { get; }
        public DataSetContext(string tempFile)
        {
            Orders = new List<Order>();

            var lines = File.ReadAllLines(@$"{tempFile}").Skip(1);

            Parallel.ForEach(lines, line =>
            {
                var order = new Order()
                {
                    OrderId = Convert.ToInt32(line.Split(",")[0]),
                    CustomerId = Convert.ToInt32(line.Split(",")[1]),
                    ItemId = Convert.ToInt32(line.Split(",")[2]),
                    DateTime = Convert.ToDateTime(line.Split(",")[3]),
                    GrossAmount = Convert.ToInt32(line.Split(",")[4].Replace(".0", "")),
                    City = line.Split(",")[5],
                    QuantityId = Convert.ToInt32(line.Split(",")[6].Replace(".0", ""))
                };

                lock (Orders)
                {
                    Orders.Add(order);
                }
            });
        }
    }
}
