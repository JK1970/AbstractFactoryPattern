using AbstractFactoryPattern.AbstractHardware;

namespace AbstractFactoryPattern.ConcreteHardware
{
    internal class Ram1 : Ram
    {
        public override void GetRamInformation()
        {
            Console.WriteLine("16 Gb");
        }
    }
}