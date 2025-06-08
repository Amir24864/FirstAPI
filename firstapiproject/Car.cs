namespace First_Project
{
    public abstract class Car
    {
        public string Name { get; set; }
        public Wheel Wheel { get; set; } = new Wheel();
        public Engine Engine { get; set; }

        public Car(string name, string engineModel)
        {
            Name = name;
            Engine = new Engine(engineModel);
        }

        public abstract void DisplayInfo();
    }

}
