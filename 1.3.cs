using System;
using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество сотрудников");
            int kol = int.Parse(Console.ReadLine());
            ArrayList zp = new ArrayList();
            ArrayList ing = new ArrayList();
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine("введите фамилию имя");
                string name = Console.ReadLine();
                Console.WriteLine("выберите должность сотрудника из списка: 1-инженер, 2-директор, 3-администратор, 4-разработчик, 5-уборщи(к/ца)");
                int dol = int.Parse(Console.ReadLine());
                if (dol > 0 && dol < 6)
                {
                    Console.WriteLine("введите минимальная зарплата сотрудника");
                    int p = int.Parse(Console.ReadLine());
                    Console.WriteLine("коэффициент повышающий з/п");
                    int k = int.Parse(Console.ReadLine());
                    zp.Add(new Sotrudnik(name, p, k));
                    if (dol == 1)
                    {
                        Console.WriteLine("введите количество разработанных проектов");
                        int n = int.Parse(Console.ReadLine());
                        ing.Add(new Injener(name, p, k, n));
                    }
                }
                else { break; }
            }
            Console.WriteLine("Общий список: ");
            foreach (Sotrudnik item in zp)
            {
                item.Show();
            }
            foreach (Injener item in ing)
            {
                item.show();
            }
            Console.ReadLine();
        }
    }
    class Sotrudnik
    {
        public string name;
        public int p;
        public int k;
        public Sotrudnik(string name, int p, int k)
        {
            this.name = name;
            this.p = p;
            this.k = k;
        }
        public int ZP()
        {
            return p * k;
        }
        public void Show()
        {
            Console.WriteLine($"ФИО:{name}, Минимальная з/п:{p} р, коэффициент повышения з/п:{k}, конечная з/п:{ZP()} р");
        }
    }
    class Injener : Sotrudnik
    {
        protected int n;
        private int dohod;
        public Injener(string name, int p, int k, int n)
            : base(name, p, k)
        {
            this.n = n;
        }
        new public void show()
        {
            if (n > 10)
            {
                dohod = (k * p) * (n / 10);
                Console.WriteLine($"конечная з/п инженера:{name}, {dohod} р");
            }
        }
    }
}
