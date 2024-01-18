namespace csproject;
public class Day4_Program3
{
    static void Run()
    {
        Cuboid cube = new(3, 5, 7);
        Console.WriteLine("volume: {0}", cube.Volume);
        Console.WriteLine("perimeter: {0}", cube.Perimeter);
    }
    class Rectangle
    {
        public int Length, Breadth;
        public int Perimeter { get => 2 * (Length + Breadth); }
    }
    class Cuboid : Rectangle
    {
        public int Height;
        public Cuboid(int l, int b, int h)
        {
            Length = l;
            Breadth = b;
            Height = h;
        }
        public int Volume { get => Length * Breadth * Height; }
    }
}