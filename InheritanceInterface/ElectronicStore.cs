namespace InheritanceInterface
{
    public class ElectronicStore : IElectronicStore
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public virtual string Test()
        {

        }
    }
}
