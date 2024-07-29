namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle GetVehicle(string vehicleType)
    {
        switch (vehicleType.ToLower())
        {
            case "4":
                return new Car();
            case "2":
                return new Motorcycle();
            default :
                return new Car();
        }
    }
}