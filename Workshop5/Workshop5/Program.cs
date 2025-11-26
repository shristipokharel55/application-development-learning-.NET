using System.Security.Principal;

namespace Workshop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Task 1: Encapsulation \n");

            //create a new bank account with an initial balance of 500
            BankAccount acc = new BankAccount("123456", 500);

            //display the account number and balance
            Console.WriteLine($"Account Number: {acc.AccountNumber}, Balance: {acc.Balance}");

            // Deposit
            acc.Deposit(300);

            // Withdraw
            acc.Withdraw(750);

            // Print remaining balance
            Console.WriteLine("Remaining Balance: " + acc.Balance);

            //Task 2
            Console.WriteLine("\nTask 2: Inheritance \n");

            //creating object of Car
            Car car = new Car();
            car.brand = "Lamborgini";
            car.speed = 100;
            car.Seat = 2;

            // Motorcycle Object
            Motorcycle bike = new Motorcycle();
            bike.brand = "Honda";
            bike.speed = 80;
            bike.Model = "Hornet 2.0";

            // Demonstrating code reusability (inherited methods)
            Console.WriteLine("Car Details: ");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine("\nMotorcycle Details: ");
            bike.Start();
            bike.DisplayInfo();
            bike.Stop();

            //Task 3
            Console.WriteLine("\nTask 3: Polymorphism \n");

            Printer printer = new Printer();
            int number = 5;

            // Calling overloaded methods
            printer.Print("Hi this is workshop 5");
            printer.Print($"This is number {number}");
            printer.Print("Task 3 completed", 3);

            // Nepali Teacher
            NepaliTeacher nepaliTeacher = new NepaliTeacher();
            nepaliTeacher.Name = "Bhupendra Poudel";
            Console.WriteLine("Name: " + nepaliTeacher.Name);
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();

            Console.WriteLine();

            // English Teacher
            EnglishTeacher englishTeacher = new EnglishTeacher();
            englishTeacher.Name = "Khilendra Chaudhary";
            Console.WriteLine("Name: " + englishTeacher.Name);
            englishTeacher.Teaching();        // Uses base class method
            englishTeacher.SalaryInfo();      

            //task 4
            Console.WriteLine("\nTask 4: Abstraction \n");

            CarAbstract carab = new CarAbstract();
            BikeAbstract bikeab = new BikeAbstract();

            Console.WriteLine("Car: ");
            carab.Display();
            carab.StartEngine();
            carab.StopEngine();

            Console.WriteLine("\nBike: ");
            bikeab.Display();
            bikeab.StartEngine();
            bikeab.StopEngine();

            //task 5
            Console.WriteLine("\nTask 5: OOP \n");

            ElectronicStore store = new ElectronicStore();

            Laptop laptop = new Laptop("ASUS Vivobook", 100000);
            Smartphone phone = new Smartphone("Samsung S25 Ultra", 200000);

            store.AddDevice(laptop);
            store.AddDevice(phone);

            store.ShowAllDeviceDetails();

        }
    }
}
