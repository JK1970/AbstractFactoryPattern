using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            AbstractComputerFactory factory = new GamingLaptopFactory();

            Processor gamingLaptopProcessor = factory.GetProcessor();
            gamingLaptopProcessor.GetProcessorInformation();

            Ram gamingLaptopRam = factory.GetRam();
            gamingLaptopRam.GetRamInformation();

            HardDrive gamingLaptopHardDrive = factory.GetHardDrive();
            gamingLaptopHardDrive.GetHardDriveInformation();

            /*  AbstractComputerFactory factory = new PowerPcFactory();
             factory.GetProcessor();
             factory.GetRam();
             factory.GetHardDrive(); */
        }
    }
}