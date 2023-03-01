using AbstractFactoryPattern.AbstractHardware;

namespace AbstractFactoryPattern.ConcreteHardware
{
    internal class Processor2 : Processor
    {
        public override void GetProcessorInformation()
        {
            Console.WriteLine("Core 5");
        }
    }
}