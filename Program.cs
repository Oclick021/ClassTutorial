// See https://aka.ms/new-console-template for more information
using ClassTutorial;

Console.WriteLine("Hello, World!");


Car Quick = GiveMeCarInfo("ABC");
Car Pride = GiveMeCarInfo("GHI");
Car Peykan = GiveMeCarInfo("");
Car P206 = GiveMeCarInfo("DEF");


Console.WriteLine(Quick.Name);


Car GiveMeCarInfo(string chasisNumber)
{
    Car car = new Car();

    switch (chasisNumber)
    {
        case "ABC":
            //IT is a Quick R with Grey bumper and black hood
            car.Name = "Quick";
            car.CarPaint = new CarPaint("White", "Black", "White", "Grey");
            break;

        case "DEF":
            // 206 Type 5 white
            car.Name = "Peagut 206";
            car.CarPaint = new CarPaint("White");

            break;

        case "GHI":
            // Pride 110 daghoon
            car.Name = "Saipa 110";
            car.CarPaint = new CarPaint("Silver");

            break;
        default:
            //Peykan
            car.Name = "Peykan Javanan";
            car.CarPaint = new CarPaint("Gojeyi");
            break;
    }
    return car;
}