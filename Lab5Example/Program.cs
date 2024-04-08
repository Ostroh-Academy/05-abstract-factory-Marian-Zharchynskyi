namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {

                CarClient hondaClient;
                CarClient toyotaClient;
                Console.WriteLine("\r\n------------This is HONDA Car Factory----------------");
                hondaClient = new CarClient(new HondaFactory(), "compact");
                Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSedanName() + " as compact Sedan");
                Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSuvName() + " as compact SUV");

                hondaClient = new CarClient(new HondaFactory(), "full");
                Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSedanName() + " as full Sedan");
                Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSuvName() + " as full SUV");

                Console.WriteLine("\r\n\r\n------------This is TOYOTA Car Factory----------------");
                toyotaClient = new CarClient(new ToyotaFactory(), "compact");
                Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSedanName() + " as compact Sedan");
                Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSuvName() + " as compact SUV");

                toyotaClient = new CarClient(new ToyotaFactory(), "full");
                Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSedanName() + " as full Sedan");
                Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSuvName() + " as full SUV");
                Console.ReadLine();
            
        }
    }
}
