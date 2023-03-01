using AbstractFactoryPattern.AbstractHardware;

namespace AbstractFactoryPattern.ConcreteHardware
{
    internal class HardDrive3 : HardDrive
    {
        public override void GetHardDriveInformation()
        {
            Console.WriteLine("4 Tb");
        }
    }
}