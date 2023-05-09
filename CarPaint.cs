namespace ClassTutorial
{
    class CarPaint
    {
        public string MainColor { get; set; }
        public string HoodColor { get; set; }
        public string DoorsColor { get; set; }
        public string BumperColor { get; set; }

        public CarPaint(string mainColor)
        {
            MainColor = mainColor;
            HoodColor = mainColor;
            DoorsColor = mainColor;
            BumperColor = mainColor;
        }

        public CarPaint(string mainColor, string hoodColor, string doorsColor, string bumperColor)
        {
            MainColor = mainColor;
            HoodColor = hoodColor;
            DoorsColor = doorsColor;
            BumperColor = bumperColor;
        }
    }
}
