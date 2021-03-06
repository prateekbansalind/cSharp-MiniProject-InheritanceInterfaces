namespace InheritanceInterface
{
    public class WashingMachine : ElectronicStore, IElectronicStore
    {
        public int MachineLoad { get; set; }

        public override string ToString()
        {
            return $"Product Name : { ProductName } | Product Price :  { ProductPrice }  | Machine Load Capacity:  { MachineLoad}";
        }

        public override string Test()
        {
            return $"Product Name : { ProductName } | Product Price :  { ProductPrice }  | Operating System:  { MachineLoad }";
        }
    }
}
