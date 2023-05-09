namespace ClassTutorial
{
    class Car
    {
        string model;
        bool sportWheels;
        bool airco;
        int airbacks;


        public string Name { get; set; }
        public CarPaint CarPaint { get; set; }

        public Car()
        {

        }
        public Car(string name, CarPaint paint)
        {
            Name = name;
            CarPaint = paint;
        }

    }
}
