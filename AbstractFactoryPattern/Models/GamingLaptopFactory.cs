namespace AbstractFactoryPattern.Models
{
    public class GamingLaptopFactory : AbstractComputerFactory
    {
        public override Processor GetProcessor()
        {
            return new Processor1();
        }
        public override Ram GetRam()
        {
            return new Ram2();
        }
        public override HardDrive GetHardDrive()
        {
            return new HardDrive3();
        }
    }
}