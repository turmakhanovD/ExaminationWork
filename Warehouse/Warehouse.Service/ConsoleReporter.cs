using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Service.Abstract;

namespace Warehouse.Service
{
    public class ConsoleReporter : IReporter
    {
        public void Report()
        {
            Console.WriteLine("Событие AddPressed cработало. Измениния были сохранены в ХМЛ файл");
        }
    
    }
}
