namespace DesignPatternFactory
{
    public class VehicleCreator
    {
        public static Vehicle GetVehicle(int passengers)
        {
            if (passengers <= 5)
                return new Car();
            if (passengers <= 50)
                return new Bus();
            return new Boat();
        }
    }
}
