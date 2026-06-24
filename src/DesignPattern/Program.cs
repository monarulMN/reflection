using DesignPattern.AbstractFactoryExample;
using DesignPattern.BuilderExample;
using DesignPattern.PrototypeExample;
using DesignPattern.SingletonExample;

Console.WriteLine("Hello, World!");


//var bus1 = Bus.CreateBus();

//bus1.SeatCount = 7;
//bus1.Speed = 42;


//var bus2 = Bus.CreateBus();

//bus2.SeatCount = 1;
//bus2.Speed = 45;


//var bus3 = Bus.CreateBus();

//bus3.SeatCount = 5;
//bus3.Speed = 40;

var message = ErrorLogger.CreateLogger();
var message2 = ErrorLogger.CreateLogger();


var product1 = new Product { Name = "Laptop", Price = 9999 };

var product2 = product1.Copy();

Console.WriteLine($"Product1 : {product1.Name}");
Console.WriteLine($"Product2 : {product2.Price}");

IceCreamBuilder iceCreamBuilder = new IceCreamBuilder();
iceCreamBuilder.SetFlavor("Vanilla");
iceCreamBuilder.AddToppings("Chocolate chips");
IceCream iceCream = iceCreamBuilder.Make();


FighterFactory factory = new Mig29FighterFactory();

Fighter fighter = factory.CreateFighter();
Missile missile = factory.CreateMissile();
Bomb bomb =  factory.CreateBomb();