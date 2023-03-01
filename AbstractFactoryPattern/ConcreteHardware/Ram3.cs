using AbstractFactoryPattern.AbstractHardware;

namespace AbstractFactoryPattern.ConcreteHardware
{
    internal class Ram3 : Ram
    {
        public override void GetRamInformation()
        {
            Console.WriteLine("64 Gb");
        }
    }
}