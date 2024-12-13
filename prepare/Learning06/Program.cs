using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning06 World!");
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("pink", 10);
        Rectangle r1 = new Rectangle("blue", 10, 20);
        Circle c1 = new Circle("yellow", 1);
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        for(int i = 0; i < shapes.Count; i++){
            Console.WriteLine($"Area: {shapes[i].GetArea()}");
            Console.WriteLine($"Color: {shapes[i].GetColor()}");
        }
    }
}