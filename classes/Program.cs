class Car
{
    // Methods and Fields of a class are called 'Members'

    // Fields get created at top level
    // You can add a default option or just initialize it
    string color;
    string brand = "Jeep";

    // Methods also go here
    public void Honk()
    {
        Console.WriteLine("*BEEP BEEP*");
    }

    // Blank Constructor
    public Car()
    {
        color = "red";
    }
    // Two Arg Constructor
    public Car(string newColor, string newBrand)
    {
        color = newColor;
        brand = newBrand;
    }

    // Program Starts here
    static void Main(string[] args)
    {
        // Must initialize to use
        Car myCar = new Car("Blue", "Kia");
        Console.WriteLine(myCar.brand);
        Console.WriteLine(myCar.color);
        // Once instantiated you can reassign fields like this
        myCar.brand = "Ford";
        Console.WriteLine(myCar.brand);
        myCar.Honk();
    }
}

