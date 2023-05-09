namespace ClassTutorial
{
    class Car
    {
        string model;
        bool sportWheels;
        bool airco;
        int airbacks;

        public bool IsLocked { get; set; }
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


        public void Lock()
        {
            IsLocked = true;
        }


        public void UnLock()
        {
            IsLocked = false;
        }

        public void ToggleLock()
        {
            if (IsLocked)
            {
                UnLock();
            }
            else
            {
                Lock();
            }
        }
    }
}
