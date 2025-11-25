using System;

public class RentalCarDriver
{
    public static void Main(string[] args)
    {
        RentalCar c1 = new RentalCar("Toyota", "Corolla", "Saloon", "ABC-123", 5000, false);
        RentalCar c2 = new RentalCar("Honda", "Civic", "HatchBack", "XYZ-987", 6000);
        RentalCar c3 = new RentalCar("BMW", "Z4", "Convertible");
        RentalCar c4 = new RentalCar("Suzuki", "Swift", "HatchBack", "LMN-555", 4000);

        c1.display();
        c2.display();
        c3.display();
        c4.display();

        Console.WriteLine("Borrowing Car 1...");
        c1.borrow();
        Console.WriteLine("Car 1 Borrowed: " + c1.checkBorrowed());
        c1.display();

        Console.WriteLine("Returning Car 1...");
        c1.returnRentalCar();
        Console.WriteLine("Car 1 Borrowed: " + c1.checkBorrowed());

        Console.WriteLine("Changing Price of Car 2...");
        c2.changePrice(6500);
        Console.WriteLine("New Price: " + c2.checkPrice());

        Console.WriteLine("\nFinal Updated Data:");
        c1.display();
        c2.display();
        c3.display();
        c4.display();
    }
}
