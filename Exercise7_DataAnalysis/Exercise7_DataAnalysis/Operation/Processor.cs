using Exercise7_DataAnalysis.Model;
using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace Exercise7_DataAnalysis.Operation
{
    class Processor
    {
        List<Order> Orders;
        public Processor(List<Order> orders)
        {
            Orders = orders;
        }
        public long TotalSalesByYear(int year)
        {
            var list = Orders.Where(x => x.DateTime.Year == year).Select(x => x.GrossAmount).ToList();
            long total = 0;
            foreach (var item in list)
            {
                total += item;
            }
            return total;
        }
        public long TotalSalesByMonth(int month)
        {
            var list = Orders.Where(x => x.DateTime.Month == month).Select(x => x.GrossAmount).ToList();
            long total = 0;
            foreach (var item in list)
            {
                total += item;
            }
            return total;
        }
        public long TotalSalesByItem(int id)
        {
            var list = Orders.Where(x => x.ItemId == id).Select(x => x.GrossAmount).ToList();
            long total = 0;
            foreach (var item in list)
            {
                total += item;
            }
            return total;
        }
        public long TotalSalesByCustomer(int id)
        {
            var list = Orders.Where(x => x.CustomerId == id).Select(x => x.GrossAmount).ToList();
            long total = 0;
            foreach (var item in list)
            {
                total += item;
            }
            return total;
        }
        public void SepareteEachCityOrders(string filePath)
        {
            var cityList = Orders.Select(x => x.City).ToList().Distinct();
            int cityNumbers = cityList.Count();
            foreach (var city in cityList)
            {
                using (StreamWriter writer = new(filePath + $"{city}.csv"))
                {
                    foreach (var item in Orders.Where(x => x.City == city))
                    {
                        writer.WriteLine($"{item.OrderId},{item.CustomerId},{item.ItemId},{item.DateTime},{item.GrossAmount},{item.QuantityId}");
                    }
                }
            }
        }
    }
}
