namespace CommandPattern.Receiver
{
    public class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is ON");
        }
        public void TurnOff()
        {
            Console.WriteLine("TV is OFF");
        }
        public void VolumeUp()
        {
            Console.WriteLine("Volume Increased");
        }
        public void VolumeDown()
        {
            Console.WriteLine("Volume Decreased");
        }
    }
}
