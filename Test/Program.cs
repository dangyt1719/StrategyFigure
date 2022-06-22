using MathSDK;
using MathSDK.InterfacesImplemetations;
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* var circleMath = new MathSDK.MathSDK(new Circle(6)).GetArea();
            Console.WriteLine("Circle area="+ circleMath);
            var triangleMath = new MathSDK.MathSDK(new Triangle(6,3,2)).GetArea();
            Console.WriteLine("Triangle area=" + triangleMath);*/

            Console.WriteLine("Choose a figure: \n C=Circle \n T=Triangle");

                var choosed = Console.ReadKey();
                switch (choosed.Key)
                {
                    case ConsoleKey.C:
                        {
                            Console.WriteLine("\nEnter the radius of the circle");
                            var r = Convert.ToDouble(Console.ReadLine());
                            var area = new MathSDK.MathSDK(new Circle(r)).GetArea();
                            Console.WriteLine("\nCircle area=" + area);
                            break;
                        }
                    case ConsoleKey.T:
                        {
                            Console.WriteLine("\nEnter the value of side a");
                            var a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nEnter the value of side b");
                            var b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nEnter the value of side c");
                            var c = Convert.ToDouble(Console.ReadLine());
                            var area = new MathSDK.MathSDK(new Triangle(a, b, c)).GetArea();
                            Console.WriteLine("\nTriangle area=" + area);
                            break;
                        }
                default:
                    {
                        break;
                    }
                }
        }
    }
}