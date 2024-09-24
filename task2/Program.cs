using System.Diagnostics;
using System.Numerics;
using System.Security.AccessControl;
using System.Transactions;

class Programm
{
    static void Main(string[] argv)
    {
        Plane plane = new Plane(1000, 1234, 1000000, 900, 2020, 10000, 200);
        Car car = new Car(10, 20, 20000, 150, 2021);
        Ship ship = new Ship(5, 5, 500000, 50, 2019, 300, "СПБ");

        plane.PrintInfo();
        Console.WriteLine();
        car.PrintInfo();
        Console.WriteLine();
        ship.PrintInfo();
    }
}

class Vehicle
{
    public int X;
    public int Y;
    public double Price;
    public double MaxSpeed;
    public int Year;

    public Vehicle(int x, int y, double price, double maxSpeed, int year)
    {
        X = x;
        Y = y;
        Price = price;
        MaxSpeed = maxSpeed;
        Year = year;
    }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price} $");
        Console.WriteLine($"Скорость: {MaxSpeed} км/ч");
        Console.WriteLine($"Год выпуска: {Year}");
    }
}

class Plane : Vehicle
{

    public double Height;
    public int Passangers;

    public Plane(int x, int y, double price, double maxSpeed, int year, double height, int passangers) : base(x, y, price, maxSpeed, year)
    {
        Height = height;
        Passangers = passangers;
    }

    public override void PrintInfo() {
        base.PrintInfo();
        Console.WriteLine($"Высота полета: {Height} м");
        Console.WriteLine($"Количество посадочных мест: {Passangers}");
    }
}

class Car : Vehicle
{
    public Car(int x, int y, double price, double maxSpeed, int year) : base(x, y, price, maxSpeed, year)
    {
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("Тип ТС - Легковой автомобиль");
    }
}


class Ship : Vehicle
{
    public int Passangers;
    public string Port;
    public Ship(int x, int y, double price, double maxSpeed, int year, int passangers, string port) : base(x, y, price, maxSpeed, year)
    {
        Passangers = passangers ;
        Port = port;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Количество пассажиров: {Passangers}");
        Console.WriteLine($"Порт приписки: {Port}");
    }
}
