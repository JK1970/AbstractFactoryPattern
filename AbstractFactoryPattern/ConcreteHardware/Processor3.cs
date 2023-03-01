using AbstractFactoryPattern.AbstractHardware;

namespace AbstractFactoryPattern.ConcreteHardware
{
    internal class Processor3 : Processor
    {
        public override void GetProcessorInformation()
        {
            Console.WriteLine("Core 7");
        }
    }
}