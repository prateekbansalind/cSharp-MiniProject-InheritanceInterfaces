namespace InheritanceInterface
{
    public class SmartPhone : ElectronicStore, IElectronicStore
    {
        public string OperatingSystem { get; set; }

        public override string ToString()
        {
            return $"Product Name : { ProductName } | Product Price :  { ProductPrice }  | Operating System:  { OperatingSystem }";
        }
    }
}
