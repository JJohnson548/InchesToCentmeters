using System;

class Program
{
    public static void Main(string[] args)
    {

        const double CENTIMETERS_IN_INCHES = 2.54;

        double inches = 15994;

        double centimeters = inches * CENTIMETERS_IN_INCHES;


        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");


    }
}