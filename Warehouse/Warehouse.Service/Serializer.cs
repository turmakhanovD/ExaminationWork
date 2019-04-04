using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Warehouse.Model;

namespace Warehouse.Service
{
    public class Serializer
    {
        public void Serialize(List<Item> items)
        {
            FileStream stream = new FileStream("Items.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>));
            serializer.Serialize(stream, items);
            stream.Close();
        }
    }
}
