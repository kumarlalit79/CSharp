using System;

// Defining a class
public class Car
{
    // Properties
    public string Brand;
    public string Model;
    public int Year;

    // Method
    public void DisplayInfromation()
    {
        Console.WriteLine($"Brand:{Brand} , Model:{Model} , Year : {Year}");
    }
}

public  class Programming
{
    public static void main(string[] args)
    {
        // Creating an object of the class
        Car myCar = new Car();
        myCar.Brand = "RR";
        myCar.Model = "Callinum";
        myCar.Year = 2030;
        myCar.DisplayInfromation();
    }
}

