using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractHardware;
using AbstractFactoryPattern.ConcreteHardware;

namespace AbstractFactoryPattern.ConcreteFactory
{
    internal class PowerPcFactory : AbstractComputerFactory
    {
        public override Processor GetProcessor()
        {
            return new Processor2();
        }
        public override Ram GetRam()
        {
            return new Ram3();
        }
        public override HardDrive GetHardDrive()
        {
            return new HardDrive1();
        }
    }
}