namespace LiskovBacimiz;

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Rectancle is Drawing");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Circle is Drawing");
    }
}

class Program
{
    static void DrawShape(Shape shape)
    {
        shape.Draw();
    }

    static void Main()
    {
        Shape shape1 = new Rectangle();
        Shape shape2 = new Circle();

        DrawShape(shape1); 
        DrawShape(shape2);
    }
}
