using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("сторону x=");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("сторону y=");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("сторону z=");
            int z = int.Parse(Console.ReadLine());
            rectangle S = new rectangle(x, y);
            prizma P = new prizma(x, y, z);
            Console.ReadLine();
            S.Show();
            P.show();
        }
    }
    class rectangle
    {
        public int x;
        public int y;
        public rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int S()
        {
            return x * y;
        }
        public void Show()
        {
            Console.WriteLine($"площадь прямоугольника:{S()}");
        }
    }
    class prizma : rectangle
    {
        private int z;
        public prizma(int x, int y, int z)
            : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public int V()
        {
            return x * y * z;
        }
        public int Sp()
        {
            return 2 * (x * y + x * z + y * z);
        }

        new public void show()
        {
            Console.WriteLine($"объем:{V()}, площадь поверхности=: {Sp()}");
        }
    }
}
