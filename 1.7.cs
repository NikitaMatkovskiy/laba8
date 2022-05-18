using System;
using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество квартир");
            double kol = double.Parse(Console.ReadLine());
            ArrayList Sall = new ArrayList();
            ArrayList Scentr = new ArrayList();
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine("стоимость квадратного метра");
                double cena1 = double.Parse(Console.ReadLine());
                Console.WriteLine("выберите район: 1-Адмиралтейский, 2-Василеостровский, 3-Выборгский, 4-Калининский, 5-Кировский, 6-Колпинский, 7-Красногвардейский, 8-Красносельский, 9-Кронштадтский, 10-Курортный, 11-Московский, 12-Невский, 13-Петроградский, 14-Петродворцовый, 15-Приморский, 16-Пушкинский, 17-Фрунзенский, 18-Центральный");
                int N = int.Parse(Console.ReadLine());
                if (N > 0 && N < 19)
                {
                    Console.WriteLine("введите площадь квартиры в м^2");
                    double s = double.Parse(Console.ReadLine());
                    Sall.Add(new cenaob(cena1, s, N));
                }
                else if (N == 18)
                {
                    Console.WriteLine("введите площадь квартиры в м^2");
                    double s = double.Parse(Console.ReadLine()); Scentr.Add(new cenacentr(cena1, s, N));
                }

                else { break; }
            }



            Console.WriteLine("цены на квартиры: ");
            foreach (cenaob item in Sall)
            {
                item.Show();
            }
            foreach (cenacentr item in Scentr)
            {
                item.show();
            }
            Console.ReadLine();
        }
    }
    class cenaob
    {
        public double cena1;
        public double s;
        public int n;
        public cenaob(double cena1, double s, int n)
        {
            this.cena1 = cena1;
            this.s = s;
            this.n = n;
        }
        public double obst()
        {
            return cena1 * s;
        }
        public void Show()
        {
            Console.WriteLine($"стоимость квартиры в {n} районе:{obst()} р");
        }
    }
    class cenacentr : cenaob
    {

        public cenacentr(double cena1, double s, int n)
            : base(cena1, s, n)
        {
            this.cena1 = cena1;
            this.s = s;
            this.n = n;
        }
        public double centst()
        {
            return cena1 * s + (cena1 * s * 0.1);
        }
        new public void show()
        {
            Console.WriteLine($"стоимость квартиры в {n} районе:{centst()} р");

        }
    }
}
