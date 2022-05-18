using System;
using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество студентов");
            int kol = int.Parse(Console.ReadLine());
            ArrayList stud = new ArrayList();
            ArrayList studmag = new ArrayList();
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine("введите фамилию имя");
                string name = Console.ReadLine();
                Console.WriteLine("выберите если студент-1, если студент магистратуры-2");
                int kto = int.Parse(Console.ReadLine());
                if (kto == 1)
                {
                    Console.WriteLine("средний бал");
                    int s = int.Parse(Console.ReadLine());
                    stud.Add(new student(name, s));
                }
                else if (kto == 2)
                {
                    Console.WriteLine("средний бал");
                    int s = int.Parse(Console.ReadLine());
                    studmag.Add(new studentmag(name, s));
                }
                else { break; }
            }
            Console.WriteLine("Общий список: ");
            foreach (student item in stud)
            {
                item.Show();
            }
            foreach (studentmag item in studmag)
            {
                item.show();
            }
            Console.ReadLine();
        }
    }
    class student
    {
        public string name;
        public int s;
        public student(string name, int s)
        {
            this.name = name;
            this.s = s;
        }
        public int stip()
        {
            return 300 + 100 * (s - 5);
        }
        public void Show()
        {
            Console.WriteLine($"ФИО:{name}, стипендия:{stip()} р");
        }
    }
    class studentmag : student
    {

        public studentmag(string name, int s)
            : base(name, s)
        {
            this.s = s;
        }
        public int stip()
        {
            return 100 + 300 + 100 * (s - 5);
        }
        new public void show()
        {
            Console.WriteLine($"ФИО:{name}, стипендия:{stip()} р");

        }
    }
}
