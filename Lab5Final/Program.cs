namespace Lab5Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHeadphonesFactory wirelessFactory = new WirelessHeadphonesFactory();
            IHeadphones wirelessHeadphones = wirelessFactory.CreateHeadphones();
            Console.WriteLine(wirelessHeadphones.GetDescription());

            IHeadphonesFactory wiredFactory = new WiredHeadphonesFactory();
            IHeadphones wiredHeadphones = wiredFactory.CreateHeadphones();
            Console.WriteLine(wiredHeadphones.GetDescription());
        }
    }
}
