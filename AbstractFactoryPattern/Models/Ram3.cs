namespace AbstractFactoryPattern.Models
{
    internal class Ram3 : Ram
    {
        public override void GetRamInformation()
        {
            Console.WriteLine("64 Gb");
        }
    }
}