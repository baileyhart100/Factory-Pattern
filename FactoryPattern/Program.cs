namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfWheels;
            bool input = false;

            do
            {
                Console.WriteLine($"How many wheels does the vehicle that you want to make have?");
                input = int.TryParse(Console.ReadLine(), out numberOfWheels);
            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);

            vehicle.Drive();

           
          
        }
    }
}
