/* //overload 
class Program
{
    static void Main()
    {
        double[] arr = new double[]
            {
                2, 3.3, 5, 5, 89.0, 112.2, 98, 77
            };

        Console.WriteLine(Max(2, 3.3));
        Console.WriteLine(Max(4.7, 3.3, 48.0));
        Console.WriteLine(Max(arr));
    }
    static double Max(double number1,double number2)
    {
        return (number1 > number2) ? number1 : number2;
    }
    static double Max(double number1, double number2, double number3)
    {
        if (number1 > number2 && number1 > number3) return number1;
        else if (number2 > number1 && number2 > number3) return number2;
        else if (number3 > number2 && number3 > number1) return number3;
        else return -1;
    }
    static double Max(double[] arr)
    {
        if (arr != null)
        {
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        else return -1;
    }
}*/
/*//override
namespace ConsoleApp1
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shakl chizildi");
        }
    }

    public class Circle : Shape
    {
        private float _radius;
        public Circle(float radius)
        {
            this._radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Radiusi {_radius} ga teng bo'lgan aylana chizildi");
        }
    }

    public class Triangle : Shape
    {
        private float _a;
        private float _b;
        private float _c;

        public Triangle(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override void Draw()
        {
            Console.WriteLine($"Tomonlari {_a} {_b} {_c} ga teng bo'lgan" +
                $" uchburchak chizildi");
        }
    }

    public class Rectangle : Shape
    {
        private float _width;
        private float _height;

        public Rectangle(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Tomonlari {_width} {_height} ga teng bo'lgan" +
                $" to'rtburchak chizildi");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.Draw();
            Triangle triangle = new Triangle(3, 4, 5);
            triangle.Draw();
            Rectangle rectangle = new Rectangle(4, 5);
            rectangle.Draw();
        }
    }
}
*/
