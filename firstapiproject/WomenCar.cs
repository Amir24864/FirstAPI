namespace First_Project
{
    public class WomenCar : Car
    {
        public WomenCar() : base("WomenCar", "T1") { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Name}, Engine: {Engine.Model}, Wheel: {Wheel.Type}");
        }
    }

}
