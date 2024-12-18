/*
 The Builder pattern provide a method to create step by step an object
 providing flexibility and clarity about the building process
 */
using Creational_Builder2;

Test1 t1 = new Test1("XXX");
Director d1 = new Director();
d1.TransT(ref t1);
Console.WriteLine(t1);

int v = 5;
d1.TransI(ref v);


Console.WriteLine("");
CarBAD sportCar = new CarBAD(CarType.SPORT, new Engine(), true);
sportCar.Fuel = 30;
CarBAD suvCar = new CarBAD(CarType.SUV, new Engine(), false);
suvCar.Fuel = 50;

CarManualBad sportCarManual = new CarManualBad(CarType.SPORT, new Engine(), true);
sportCarManual.Print();
CarManualBad suvCarManual = new CarManualBad(CarType.SPORT, new Engine(), false);
suvCarManual.Print();

Console.WriteLine("Let's use a Builder pattern");
CarBuilder carBuilder = new CarBuilder();
carBuilder.SetCarType(CarType.SPORT).SetEngine(new Engine()).IsConvertible(true);
Car sportCarBuilded = carBuilder.Build();
Console.WriteLine(sportCarBuilded.ToString());
Car sportCarBuilded2 = carBuilder.BuildAndReset();
Console.WriteLine(sportCarBuilded2.ToString());
Car sportCarBuilded3 = carBuilder.Build();
Console.WriteLine(sportCarBuilded3.ToString());

Console.WriteLine("Now I'm using a director class");

CarBuilder carBuilderDirector = new CarBuilder();
Director director = new Director();
director.ConstructSportCar(carBuilderDirector);
Car sportCarDirector = carBuilderDirector.Build();
Console.WriteLine(sportCarDirector.ToString());

director.ConstructSUVCar(carBuilderDirector);
Car suvCarDirector = carBuilderDirector.Build();
Console.WriteLine(suvCarDirector.ToString());