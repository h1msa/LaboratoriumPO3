class Program
{
    public static void Main()
    {
        List<Shape> picture = new List<Shape>();
        picture.Add(new Rectangle(){With = 34, Heih = 45});
        picture.Add(new Circle(){Radius = 6});
        List<ISwimming> swimmings = new List<ISwimming>();
        swimmings.Add(new Duck());
        List<IFlyable> flyables = new List<IFlyable>();
        flyables.Add(new Duck());
        ISwimmingBird bird = new Duck();

    }
    public static void CalculateAreas(List<Shape> shapes)
    {
        double area = 0;
        foreach (var x in shapes)
        {
            area += x.Area;
        }
        Console.WriteLine($"Suma pól{area}");
    }
}

interface ISwimmingBird: IFlyable, ISwimming
{
    //void Tweet();
}
interface IFlyable
{
    void TakeOff();
    void Fly(int distance);
    void Land();
}

interface ISwimming
{
    void Swim();
}

class Airplane : IFlyable
{
    public double FuelLevel { get; set; }

    public void TakeOff()
    {
        if (FuelLevel > 0)
        {
            Console.WriteLine("Airplane is taking of");
        }
        else
        {
            throw new Exception("Airplane doesn't have enough fuel to take of");
        }
    }


    public void Fly(int distance)
    {
        throw new NotImplementedException();
    }

    public void Land()
    {
        throw new NotImplementedException();
    }
}


class Duck : ISwimmingBird
    {
        public bool IsAlive { get; set; }

        public void TakeOff()
        {
            if (IsAlive)
            {
                Console.WriteLine("Duck is taking of");
            }
            else
            {
                throw new Exception("The duck is dead");
            }
        }

        public void Fly(int distance)
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming");
        }
    }

// instancje, dziedziczenie, abstract, interfejsy, listy kurwaaaaaaaaaaaaaaaa ile do nadrobienia dramat. Czym jest kurwa agregacja.
    abstract class Shape
    {
        public abstract double Area { get; }

        public int Color { get; set; }
    }

    class Rectangle : Shape
    {
        public double With { get; set; }
        public double Heih { get; set; }

        public override double Area
        {
            get { return With * Heih; }
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }
    }
