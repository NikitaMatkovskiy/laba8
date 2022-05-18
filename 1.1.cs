using System;
namespace ConsoleApplication1
{
    class ZU
    {
        public int x;
        public int y;
        public ZU(int x, int y)
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

            Console.WriteLine("площадь участка = {0}", S());
        }
    }
    class NAZ : ZU
    {
        private string name;
        public int r;
        private int k;

        public NAZ(int x, int y, string name, int r, int k)
            : base(x, y)
        {
            this.name = name;
            this.r = r;
            this.k = k;
        }
        public string Name
        {
            get { return name; }
            set
            {
                Console.WriteLine("пшеница, {1}");
                Console.WriteLine("рожь, {1}");
                Console.WriteLine("овес, {1}");
                Console.WriteLine("мак, {1}");

            }
        }
        new public void Show()
        {

            int kol = r * k;
            Console.WriteLine("" + name);
            Console.WriteLine("урожайность данной культуры со всего поля: {0}", kol);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину и ширину участка");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            ZU S = new ZU(x, y);
            Console.WriteLine("введите количество участков на поле");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("введите названия культуры из списка: пшеница, рожь, овес, мак");
            string name = string.Format(Console.ReadLine());
            Console.WriteLine("урожайность участка в тоннах");
            int r = int.Parse(Console.ReadLine());
            NAZ R = new NAZ(x, y, name, r, k);
            S.Show();
            R.Show();
            Console.ReadLine();
        }
    }
}
