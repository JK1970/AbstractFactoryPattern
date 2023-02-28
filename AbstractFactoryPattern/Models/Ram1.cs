namespace AbstractFactoryPattern
{
    internal class Ram1 : Ram
    {
        public override void GetRamInformation()
        {
            Console.WriteLine("16 Gb");
        }
    }
}