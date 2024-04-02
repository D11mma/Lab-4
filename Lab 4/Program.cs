
class Program
{
    static void Main()
    {
        Bicycle bicycle = new Bicycle();

        bicycle.CreateBicycle("Ardis","Green");
        bicycle.Turn(90);
        bicycle.Drive(50);
        bicycle.handlebars.ChangeColor("Red");
        bicycle.ChangeWheel(new Wheel("Rosava", "Blue", 26.5));
        Console.WriteLine(bicycle.frame.ToString());
        Console.WriteLine(bicycle.wheels.ToString());
        Console.WriteLine (bicycle.handlebars.Angle);
        Console.WriteLine(bicycle.GetSpeed());
        bicycle.frame.Material = "Aluminum";
        bicycle.handlebars.Material = "Plastic";
        bicycle.pedals.TypeOfpadel = "Гірські";
        Console.WriteLine(bicycle.ToString());
    }
}