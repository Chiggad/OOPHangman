namespace InterfaceÖvning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            Car volvo = new Car();
            Tractor lambo = new Tractor();

            Console.WriteLine("Car");
            volvo.Accelerate(100);

            Console.WriteLine("Tractor");
            lambo.AccelerateSlowly(20);

            List<IVehicle> myVehicles = new List<IVehicle>();

            myVehicles.Add(volvo);
            myVehicles.Add(lambo);

            var slowVehicles = myVehicles.Where(Vehicle => Vehicle.Speed > 10).ToList();

            foreach (IVehicle vehicle in slowVehicles)
            {
                Console.WriteLine(vehicle);
            }
            */

            Circle circle1 = new Circle(1.5);

            Rectangle rectangle1 = new Rectangle(1.5, 2);

            List<IShape> shapes = new List<IShape>();
            shapes.Add(circle1);
            shapes.Add(rectangle1);

            var biggerArea = shapes.Where(shape => shape.GetArea() > 2).ToList();

            foreach (IShape shape in biggerArea)
            {
                Console.WriteLine(shape);
            }
        }
    }
}