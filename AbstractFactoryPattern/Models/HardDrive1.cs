namespace AbstractFactoryPattern
{
    internal class HardDrive1 : HardDrive
    {
        public override void GetHardDriveInformation()
        {
            Console.WriteLine("1 Tb");
        }
    }
}