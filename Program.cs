// See https://aka.ms/new-console-template for more information
using ClassTutorial;

Console.WriteLine("Hello, World!");

//Add Model to cars 
//Add new car chasisnumber LMN => Logan black with grey bumper. 


Car Quick = GiveMeCarInfo("ABC");
Car Pride = GiveMeCarInfo("GHI");
Car Peykan = GiveMeCarInfo("");
Car P206 = GiveMeCarInfo("DEF");
Car Logan = GiveMeCarInfo("LMN");
List<Car> Cars = new List<Car>();
Cars.Add(Quick);
Cars.Add(Pride);
Cars.Add(Peykan);
Cars.Add(P206);
Cars.Add(Logan);


//Lock the cars that have Beige color from the list. 

Console.WriteLine(Quick.Name);


Car GiveMeCarInfo(string chasisNumber)
{
    Car car = new Car();

    switch (chasisNumber)
    {
        case "ABC":
            //IT is a Quick R with Grey bumper and black hood
            car.Name = "Quick";
            car.Model = "R";
            car.CarPaint = new CarPaint("White", "Black", "White", "Grey");

            break;

        case "DEF":
            // 206 Type 5 white
            car.Name = "Peagut 206";
            car.Model = "Type 5";
            car.CarPaint = new CarPaint("White");

            break;

        case "GHI":
            // Pride 110 daghoon
            car.Name = "Saipa 110";
            car.Model = "Pride daghoon";
            car.CarPaint = new CarPaint("Silver");

            break;

        case "LMN":
            // Logan
            car.Name = "Renault";
            car.Model = "Logan";
            car.CarPaint = new CarPaint("Beige");

            break;

        default:
            //Peykan Javanan
            car.Name = "Iran Khodro";
            car.Model = "Peykan Javanan";
            car.CarPaint = new CarPaint("Gojeyi");

            break;
    }
    return car;
}