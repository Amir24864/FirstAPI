namespace First_Project
{
    public class FamilyCar : Car
    {
        public FamilyCar() : base("FamilyCar", "T1") { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Name}, Engine: {Engine.Model}, Wheel: {Wheel.Type}");
        }
    }

}
