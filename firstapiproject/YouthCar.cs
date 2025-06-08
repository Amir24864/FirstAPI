namespace First_Project
{
    public class YouthCar : Car
    {
        public YouthCar() : base("YouthCar", "R78") { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Name}, Engine: {Engine.Model}, Wheel: {Wheel.Type}");
        }
    }

}
