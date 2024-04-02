public class Bicycle
{
    public string Brand { get; set; }

    public string Color { get; set; }

    private bool isMoving; // чи рухається велосипед
    private int Speed { get; set; }

    public Wheel wheels { get; set; }

    public Frame frame { get; set; }
    public Handlebars handlebars { get; set; }

    public Pedals pedals { get; set; }
    public Bicycle() { } // пустий конструктор 
    public Bicycle(string Brand, string Color) // конструктор, щоб задати бренд та колір 
    {
        this.Brand = Brand;
        this.Color = Color;
    }
    public void CreateBicycle() // ініціалізація 
    {
        wheels = new Wheel();
        pedals = new Pedals();
        frame = new Frame();
        handlebars = new Handlebars();
    }
    public void CreateBicycle(string Brand, string Color) // теж саме, але з брендом та кольором 
    {
        this.Brand = Brand;
        this.Color = Color;
        wheels = new Wheel(Brand,Color);
        pedals = new Pedals(Brand,Color);
        frame = new Frame(Brand, Color);
        handlebars = new Handlebars(Brand, Color);
    }
    public void Turn(int Angle)
    {
        handlebars.Angle = Angle;
        Console.WriteLine("Кут повернення керма " + Angle);
    }

    public void Drive(int Speed)
    {
       isMoving = true;
       this.Speed = Speed;
       Console.WriteLine("Велосипед поїхав зі швидкістю " + this.Speed);
    }
    public int GetSpeed() // дізнатися швидкість 
    {
        return this.Speed;
    }
    public void ChangeSpeed(int Speed)
    {
        this.Speed = Speed;
        Console.WriteLine("Велосипед змінив швидкість " + Speed);
        if (Speed == 0)
        {
            isMoving = false;
        }
        else isMoving = true;       
    }
    public void Stop()
    {
        this.Speed = 0;
        isMoving = false;
        Console.WriteLine("Велосипед зупинився");
    }
    public bool IsMoving()
    {
        return isMoving;       
    }
    public void ChangeWheel(Wheel wheel) // метод зміни колес 
    {
        this.wheels = wheel;
        Console.WriteLine($"Колеса змінено на {wheel.Color} {wheel.Brand} {wheel.Diameter} cm");
    }

    public void ChangeBicycleColor(string color)
    {
        Color = color;
        this.frame.Color = color;
        this.Color = color;
        this.wheels.Color = color;
        this.handlebars.Color = color;
        this.pedals.Color = color;
        Console.WriteLine("Колір змінено на " + this.Color); 
    }
    public void ChangeColor(string color)
    {
        this.Color = color;

    }
    public override string ToString()
    {
        return $"Brand: {Brand}; Color: {Color} \n Frame: "+frame.ToString()+"\n Wheels: "+wheels.ToString()+
            "\n Handlebars: "+handlebars.ToString()+"\n Pedals: "+pedals.ToString();
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        if (obj is Bicycle bicycle)
        {
            return Brand == bicycle.Brand && Color == bicycle.Color;
        }
        return false;
    }
}
public class Wheel : Bicycle // Клас Колесо  
{
    public double Diameter { get; set; }

    public Wheel() { } // порожній конструктор 
    public Wheel(string Brand, string Color) // конструктор з брендом, кольором та діаметром 
        : base(Brand, Color) { }
    public Wheel(string Brand, string Color, double Diameter)
        : base(Brand, Color) 
    {
        this.Diameter = Diameter;
    }
    public override string ToString()
    {
        return $"Brand: {Brand}; Color: {Color}; Diametr {Diameter}";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Wheel bicycle)
        {
            return Brand == bicycle.Brand && Color == bicycle.Color && Diameter == bicycle.Diameter;
        }
        return false;
    }
}

public class Frame : Bicycle  // Клас Рами 
{
    public string Material { get; set; }
    public Frame() { }
    public Frame(string Brand, string Color)
        : base(Brand, Color) { }

    public override string ToString()
    {
        return $"Brand: {Brand}; Color: {Color}; Material: {Material}";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Frame bicycle)
        {
            return Brand == bicycle.Brand && Color == bicycle.Color && Material == bicycle.Material;
        }
        return false;
    }
}
public class Handlebars : Bicycle // Клас Кермо 
{
    public double LenghtOfHandlebarse { get; set; }

    public Handlebars() { }
    public Handlebars(string Brand, string Color)
        :base(Brand, Color) { }
    public int Angle { get; set; }
    public string Material { get; set; }
    public override string ToString()
    {
        return $"Brand: {Brand}; Color: {Color}; Material: {Material}";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Handlebars bicycle)
        {
            return Material == bicycle.Material && this.Color == bicycle.Color;
        }
        return false;
    }
}

public class Pedals : Bicycle // Клас Педалі 
{
    public string TypeOfpadel { get; set; }

    public Pedals() { }
    public Pedals(string Brand, string Color) 
        : base(Brand, Color) { }
    public override string ToString()
    {
        return $"Brand: {Brand}; Color: {Color}; Type of pedals: {TypeOfpadel}";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Pedals bicycle)
        {
            return TypeOfpadel == bicycle.TypeOfpadel && Color == bicycle.Color;
        }
        return false;
    }
}