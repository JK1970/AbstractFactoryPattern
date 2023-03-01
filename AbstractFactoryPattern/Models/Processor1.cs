using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern
{
    internal class Processor1 : Processor
    {
        public override void GetProcessorInformation()
        {
            Console.WriteLine("Core 3");
        }

    }
}