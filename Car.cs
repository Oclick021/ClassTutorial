namespace ClassTutorial
{
    class Car
    {
        string model;
        bool sportWheels;
        bool airco;
        int airbacks;


        public string Name { get; set; }
        public string Model { get; set; }
        public CarPaint CarPaint { get; set; }

        public Car()
        {

        }
        public Car(string name, CarPaint paint, string model)
        {
            Name = name;
            CarPaint = paint;
            Model = model;
        }

    }
}
