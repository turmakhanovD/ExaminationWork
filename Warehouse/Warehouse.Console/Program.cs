using Warehouse.Service;
using Warehouse.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Warehouse.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Warehouse warehouse = new Model.Warehouse();
            List<Item> warehouses = new List<Item>();
            Item item = new Item()
            {
                Name = "Шампунь",
                Description = "Шампунь Head'n'Shoulders не шипит глаза",
                Price = 3000,
                WhenAdded = DateTime.Now
            };
            ConsoleReporter consoleReporter = new ConsoleReporter();
            Serializer serializer = new Serializer();
            ConsoleKeyInfo key;

            while (true)
            {
                key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    warehouse.AddToWarehouse(warehouses, item);
                    serializer.Serialize(warehouses);
                }
                consoleReporter.Report();               
            }

        }

    }
}
