namespace AbstractFactoryPattern.Models
{
    internal abstract class AbstractComputerFactory
    {
        public abstract Processor GetProcessor();
        public abstract Ram GetRam();
        public abstract HardDrive GetHardDrive();
    }
}