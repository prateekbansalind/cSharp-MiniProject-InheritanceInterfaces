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
                string productToBuy = UserMessages.GetAString("Choose (mobile/washing-machine): ");

                if (productToBuy.ToLower() == "mobile")
                {
                    string productName = UserMessages.GetAString("Enter a product name: ");
                    int productPrice = UserMessages.GetAInteger("Enter a product price: ");
                    string operatingSystem = UserMessages.GetAString("Enter a operating system: ");

                    store.Add(new SmartPhone { ProductName = productName, ProductPrice = productPrice, OperatingSystem = operatingSystem });
                }

                else
                {
                    string productName = UserMessages.GetAString("Enter a product name: ");
                    int productPrice = UserMessages.GetAInteger("Enter a product price: ");
                    int machineLoad = UserMessages.GetAInteger("Enter a machine load: ");

                    store.Add(new WashingMachine { ProductName = productName, ProductPrice = productPrice, MachineLoad = machineLoad });
                }

                makeAnotherEntry = UserMessages.GetAString("Do you want to make another entry (y/n): )");
                Console.WriteLine();
            } while (makeAnotherEntry.ToLower() == "y");


            foreach (IElectronicStore item in store)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
