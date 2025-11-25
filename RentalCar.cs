using System;

public class RentalCar : BaseValidation, IPrice, ICheckBorrowed
{
    public string manufacturer;
    public string model;
    public string bodyType; 
    public string registrationNumber;
    public double price;
    public bool borrowed;

    // Constructor with all 6 variables
    public RentalCar(string manufacturer, string model, string bodyType, 
                     string registrationNumber, double price, bool borrowed)
    {
        validateString(manufacturer, "Manufacturer");
        validateString(model, "Model");
        validateString(bodyType, "BodyType");
        validateString(registrationNumber, "Registration Number");
        validatePrice(price);

        this.manufacturer = manufacturer;
        this.model = model;
        this.bodyType = bodyType;
        this.registrationNumber = registrationNumber;
        this.price = price;
        this.borrowed = borrowed;
    }

    // Constructor 1 (without borrowed)
    public RentalCar(string manufacturer, string model, string bodyType,
                     string registrationNumber, double price)
        : this(manufacturer, model, bodyType, registrationNumber, price, false)
    { }

    // Constructor 2 (only 3 items)
    public RentalCar(string manufacturer, string model, string bodyType)
        : this(manufacturer, model, bodyType, "Unknown", 100, false)
    { }


    public void borrow()
    {
        if (!borrowed)
        {
            borrowed = true;
        }
        else
        {
            Console.WriteLine("ERROR: This RentalCar is already borrowed!");
        }
    }

    public void returnRentalCar()
    {
        borrowed = false;
    }

    public void changePrice(double price)
    {
        validatePrice(price);
        this.price = price;
    }

    public double checkPrice()
    {
        return price;
    }

    public bool checkBorrowed()
    {
        return borrowed;
    }

    public void display()
    {
        Console.WriteLine("*******************************");
        Console.WriteLine("Manufacturer: " + manufacturer);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("BodyType: " + bodyType);
        Console.WriteLine("Registration Number: " + registrationNumber);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("Borrowed: " + borrowed);
        Console.WriteLine();
    }
}
