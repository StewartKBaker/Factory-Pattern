namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Wheels does your vehicle have?");
            string userVehicle = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);
            vehicle.Drive();
        }
    }
}
