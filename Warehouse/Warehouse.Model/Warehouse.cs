using System.Collections.Generic;
using System.Windows.Forms;

namespace Warehouse.Model
{
    public delegate void KeyPressed( List<Item> items, Item item);

    public class Warehouse
    {
        
        public event KeyPressed AddPressed;


        public Warehouse()
        {
            AddPressed += AddToWarehouse;
        }

        public void AddToWarehouse( List<Item> items, Item item)
        {

            items.Add(item);

        }
    }
}
