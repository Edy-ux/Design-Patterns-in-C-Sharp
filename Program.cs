// See https://aka.ms/new-console-template for more information

using design_patterns.src.OopPrinciples.Polymorphism;
using design_patterns.src.OopPrinciples;
using Dumpify;
using design_patterns.src.implicit_operators;

//Console.WriteLine("Enter with amount");
//int amount = int.Parse(Console.ReadLine());


BankAccount account = new BankAccount(50);

account.Deposit(50);
account.WithDraw(20);
// account._balance.Dump();


//Implicit Operators 
decimal balance = account;

var phone = new Phone();
phone = "55 47 997155589";
//phone.Dump();  

var vehicles = new List<Vehicle>();

vehicles.Add(new Car { Brand = "Toyota", Model = "Canry", Year = 2020, NumbersOfTheDoors = 4, Name = "My Car" });
vehicles.Add(new MotoCycle { Brand = "Marley", Model = "The new Car", Year = 2020, NumberOfWheels = 2 });

// Vehicle inspection 

foreach (var vehicle in vehicles)
{

    vehicle.Start();
    /* if (vehicle is Car)
    {
        var car = (Car)vehicle;
        car.Start();

    }
    else if (vehicle is MotoCycle)
    {
        var motocycle = (MotoCycle)vehicle;
        motocycle.Start();

    } */

}

//vehicles.Dump();