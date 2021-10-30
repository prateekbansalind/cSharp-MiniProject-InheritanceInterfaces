using System;
using System.Collections.Generic;

namespace InheritanceInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IElectronicStore> store = new List<IElectronicStore>();

            string makeAnotherEntry;

            do
            {
                string productToBuy = "Choose (mobile/washing-machine): ".GetAString();

                if (productToBuy.ToLower() == "mobile")
                {
                    string productName = "Enter a product name: ".GetAString();
                    int productPrice = "Enter a product price: ".GetAInteger();
                    string operatingSystem = "Enter a operating system: ".GetAString();

                    store.Add(new SmartPhone { ProductName = productName, ProductPrice = productPrice, OperatingSystem = operatingSystem});
                }

                else
                {
                    string productName = "Enter a product name: ".GetAString();
                    int productPrice = "Enter a product price: ".GetAInteger();
                    int machineLoad = "Enter a machine load: ".GetAInteger();

                    store.Add(new WashingMachine { ProductName = productName, ProductPrice = productPrice, MachineLoad = machineLoad });
                }

                makeAnotherEntry = "Do you want to make another entry (y/n): )".GetAString();
                Console.WriteLine();
            } while (makeAnotherEntry.ToLower() == "y");


            foreach (IElectronicStore item in store)
            {
                Console.WriteLine(item.Test());
                Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
