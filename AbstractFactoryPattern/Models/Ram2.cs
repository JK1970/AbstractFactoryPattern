using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern
{
    internal class Ram2 : Ram
    {
        public override void GetRamInformation()
        {
            Console.WriteLine("32 Gb");
        }
    }
}