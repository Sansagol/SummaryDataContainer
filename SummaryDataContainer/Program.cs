using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryDataContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DataContainer> containers = new List<DataContainer>();
            containers.Add(OldMethod());
            containers.Add(NextOldMethod());
            containers.Add(NewMethod());

            int iValue = containers.First(c => c.AttrType == AttributeType.Age);
            string sValue = containers.First(c => c.AttrType == AttributeType.Name);

            Dog dValue = containers.First(c => c.AttrType == AttributeType.AnyType) as AnimalDataContainer;
        }

        private static DataContainer OldMethod()
        {
            DataContainer container = new DataContainer(12);
            DataContainer nextContainer = new DataContainer("Apple");
            return container;
        }

        private static DataContainer NextOldMethod()
        {
            DataContainer nextContainer = new DataContainer("Apple");
            return nextContainer;
        }

        private static AnimalDataContainer NewMethod()
        {
            AnimalDataContainer container = new AnimalDataContainer(new Dog());
            return container;
        }
    }
}
