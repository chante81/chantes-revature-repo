using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        string word = "Hello";

        // Object declaration and Instantiation (initialization)
        Object obj1 = new Object();
        Object obj2 = new Object();
        Object obj3 = new(); //same as above, just shortened

        DateTime currentTime = DateTime.Now;
        System.Console.WriteLine(currentTime);

        Car car1 = new Car();
        System.Console.WriteLine(car1); //Printing the object, will only print the name of the class

        car1.color = "Black";
        car1.make = "Honda";
        car1.model = "Accord";
        car1.year = 2020;

        System.Console.WriteLine($"The car is a {car1.color} {car1.year} {car1.make} {car1.model}");

        car1.Honk();
        car1.Drive(50);
        car1.Drive(150);

        Car car2 = new();

        car2.color = "White";
        car2.make = "Toyota";
        car2.model = "Camry";
        car2.year = 2022;

    System.Console.WriteLine($"Car 1 Mileage: {car1.mileage}");
    System.Console.WriteLine($"Car 2 Mileage: {car2.mileage}");

    car2.Drive(300);
    System.Console.WriteLine($"The mileage for the {car1.year} {car1.make} {car1.model} is: {car1.mileage}");
    System.Console.WriteLine($"The mileage for the {car2.year} {car2.make} {car2.model} is: {car2.mileage}");

    Car car3 = car2;
    System.Console.WriteLine(car3.color);
    System.Console.WriteLine(car3.mileage);

    // Are car3 and car2 the SAME car? Or just borrowing the same initial value?
    car2.model = "Corrolla";

    System.Console.WriteLine(car3.model);

    car2.Drive(100);
    System.Console.WriteLine($"Car2 driven 100 miles - Car2 mileage: {car2.mileage}, Car3 mileage: {car3.mileage}");
    car3.Drive(20);
    System.Console.WriteLine($"Car3 driven 20 miles - Car2 mileage: {car2.mileage}, Car3 mileage: {car3.mileage}");
    // car3 and car2 are both the same exact Car in memory

    car3 = new();
    System.Console.WriteLine($"Car3 set to new - Car2 mileage: {car2.mileage}, Car3 mileage: {car3.mileage}");

    //System.Console.WriteLine("Car1: " + car1.DisplayInfo());
    //System.Console.WriteLine("Car1: " + car2.DisplayInfo());
    // System.Console.WriteLine("Car1: " + car1.ToString());
    // System.Console.WriteLine("Car1: " + car2.ToString());
    System.Console.WriteLine("Car1: " + car1); // same as calling ToString - WriteLine has this built in when printing an object.
    System.Console.WriteLine("Car2: " + car2);
    System.Console.WriteLine("Car3: " + car3);

    Car car4 = new();
    Car car5 = new("Silver");

    System.Console.WriteLine(car4);
    System.Console.WriteLine(car5);

    Car car6 = new("Black", "Acura", "MDX", 2023, 15);
    System.Console.WriteLine(car6);
    Car car7 = new("Red", "", "Beetle", 2007, 124000);
    System.Console.WriteLine(car7);

    // How to copy over one object's value to another object.
    // No-arg
    Car car8 = new();
    car8.color = car6.color;
    car8.make = car6.make;
    //etc 

    // Full-arg
    Car car9 = new(car6.color, car6.make, car6.model, car6.year, car6.mileage);

    // Copy
    Car car10 = new(car6);
    System.Console.WriteLine(car10);

/*  Create brand new object (user/person/pizza/houses/etc.) and create class for it
    Give it some fields, methods, create a ToString, create constructors one no-arg, one full-arg
    Create new objects in main from that class - practice using them

*/
    }
}

