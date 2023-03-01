using AbstractFactoryPattern.AbstractHardware;

namespace AbstractFactoryPattern.ConcreteHardware
{
    internal class HardDrive2 : HardDrive
    {
        public override void GetHardDriveInformation()
        {
            Console.WriteLine("2 Tb");
        }
    }
}