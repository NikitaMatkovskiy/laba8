using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    abstract class Figure
    {
        abstract public double Area(); //площадь
        abstract public double Perimetr(); //периметр        
        public abstract void Display(); //вывод
    }
    class Rectanglen : Figure
    {
        private int a;
        private int b;
        public Rectanglen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return a * b;
        }
        public override double Perimetr()
        {
            return 2 * (a + b);
        }
        public override void Display()
        {
            Console.WriteLine(": a {0}, b {1}, площадь {2}, периметр {3}", a, b, Area(), Perimetr());
        }
    }
    class Circle : Figure
    {
        private double R;
        public Circle(double R)
        {
            this.R = R;
        }
        public override double Area()
        {
            return 3.14 * (R * R);
        }
        public override double Perimetr()
        {
            return 2 * (3.14 * R);
        }
        public override void Display()
        {
            Console.WriteLine(": R= {0}, площадь {1}, периметр {2}", R, Area(), Perimetr());
        }
    }
    class Triangle : Figure
    {
        private double cateta;
        private double catetb;
        private double catetc;
        public Triangle(double cateta, double catetb, double catetc)
        {
            this.cateta = cateta;
            this.catetb = catetb;
            this.catetc = catetc;
        }
        public override double Area()
        {
            return Math.Sqrt(((cateta + catetb + catetc) / 2) * (((cateta + catetb + catetc) / 2) - cateta) * (((cateta + catetb + catetc) / 2) - catetb) * (((cateta + catetb + catetc) / 2) - catetc));
        }
        public override double Perimetr()
        {
            return cateta + catetb + catetc;
        }
        public override void Display()
        {
            Console.WriteLine(": Катет А= {0}, Катет B= {1}, Катет C={2}, площадь {3}, периметр {4}", cateta, catetb, catetc, Area(), Perimetr());
        }
    }
    class Catalog
    {
        public List<Figure> list = new List<Figure>();
        public void Figure(Figure edit)
        {
            list.Add(edit);
        }
        public void Find1(int poisk)
        {
            foreach (var p in list)
                p.Display();
        }
    }
    class program
    {
        static void Main(string[] agrs)
        {
            Catalog c = new Catalog();
            Console.WriteLine("введите количество прямоугольников");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("введите сторону a=");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("введите сторону b=");
                int b = int.Parse(Console.ReadLine());
                c.Figure(new Rectanglen(a, b));
            }
            Console.WriteLine("введите количество окружностей");
            int s = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("введите радиус");
                int R = int.Parse(Console.ReadLine());
                c.Figure(new Circle(R));
            }
            Console.WriteLine("введите количество треугольников");
            int e = int.Parse(Console.ReadLine());
            for (int i = 0; i < e; i++)
            {
                Console.WriteLine("введите сторону a=");
                int cateta = int.Parse(Console.ReadLine());
                Console.WriteLine("введите сторону b=");
                int catetb = int.Parse(Console.ReadLine());
                Console.WriteLine("введите сторону c=");
                int catetc = int.Parse(Console.ReadLine());
                c.Figure(new Triangle(cateta, catetb, catetc));
            }

            foreach (var p in c.list)
            {
                p.Display();
            }
            Console.ReadLine();
        }
    }
}
