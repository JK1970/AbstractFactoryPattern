namespace AbstractFactoryPattern.Models
{
    internal class HardDrive3 : HardDrive
    {
        public override void GetHardDriveInformation()
        {
            Console.WriteLine("4 Tb");
        }
    }
}