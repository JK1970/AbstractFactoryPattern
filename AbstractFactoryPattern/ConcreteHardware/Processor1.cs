using AbstractFactoryPattern.AbstractHardware;

namespace AbstractFactoryPattern.ConcreteHardware
{
    internal class Processor1 : Processor
    {
        public override void GetProcessorInformation()
        {
            Console.WriteLine("Core 3");
        }

    }
}