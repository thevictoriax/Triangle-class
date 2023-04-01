using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace training
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating instances
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Triangle Ivan = new Triangle(13, 13, 13);
            RightTriangle Petro = new RightTriangle(10);
            Triangle Bozhena = new Triangle(10, 11, 12);
            RightTriangle Yulia = new RightTriangle(5);
            Triangle Vika = new Triangle(5, 7, 9);
            RightTriangle Stepan = new RightTriangle(6);


            //Making a container to list all triangles
            List<Triangle> container = new List<Triangle>()
            {
                Ivan, Petro, Bozhena, Yulia, Vika, Stepan
            };

            //Input();

            foreach (Triangle t in container) 
            {
                Console.WriteLine(t.ToString());
            }

            //Finding triangle with the biggest area
            var biggestArea = new Triangle();
            for (int i = 0; i<container.Count; ++i)
            {
                if (container[i] > biggestArea)
                {
                    biggestArea = container[i];
                }
            }
            Console.WriteLine($"The triangle with the biggest area is {biggestArea}");

            if (biggestArea is Triangle) 
            { 
                Console.WriteLine("The triangle with the biggest area is a COMMON TRIANGLE\n\n");
            } 
            else 
            { 
                Console.WriteLine("The triangle with the biggest area is a RIGHT TRIANGLE\n\n"); 
            }

            //Finding the sum and average sum of triangles areas
            double sum = 0;
            double avg_sum = 0;
            for(int i = 0; i<container.Count; ++i)
            {
                sum += container[i].Square();
                avg_sum = sum / container.Count;
            }
            Console.WriteLine($"The sum of triangles area: {sum}\n");
            Console.WriteLine($"The average sum of triangles area: {avg_sum}\n");

            //Creating new collection with onscribed radius
            List<double> container2 = new List<double>();
            for(int i = 0; i<container.Count; ++i)
            {
                if (container[i] is RightTriangle)
                {
                    RightTriangle rightTriangle = (RightTriangle)container[i];
                    container2.Add(rightTriangle.OnscribedRadius());
                }
            }
            foreach (double t in container2)
            {
                Console.WriteLine($"Onscribed raduis of Triangle is {t}");
            }

            void Input()
            {
                Console.WriteLine("How many triangles do you want to input?");
                int amount = int.Parse(Console.ReadLine());
                for (int i = 0; i < amount; ++i)
                {
                    Console.WriteLine("Triangle or right triangle? (t/r)");
                    string type = Console.ReadLine();
                    double a; double b; double c;
                    double side;
                    if (type == "t")
                    {
                        Console.WriteLine("Enter a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter b: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter c: ");
                        c = double.Parse(Console.ReadLine());

                        container.Add(new Triangle(a, b, c));
                    }
                    else
                    {
                        Console.WriteLine("Enter side: ");
                        side = double.Parse(Console.ReadLine());

                        container.Add(new RightTriangle(side));
                    }
                }
            }
        }
        
    }
}