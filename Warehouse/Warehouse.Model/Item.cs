using System;

namespace Warehouse.Model
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime WhenAdded { get; set; }
        public int Price { get; set; }
    }
}