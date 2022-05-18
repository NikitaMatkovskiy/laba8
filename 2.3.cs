using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    abstract class Person
    {
        public string name;
        public int data;
        public Person(string name, int data)
        {
            this.name = name;
            this.data = data;
        }
        public abstract void Display();
    }
    class Abiturient : Person
    {
        public string Fakultet;
        public Abiturient(string name, int data, string Fakultet) : base(name, data)
        {
            this.Fakultet = Fakultet;
        }
        private int vozrast()
        {
            return 2022 - data;
        }
        public override void Display()
        {
            Console.WriteLine("Information:{0},{1},{2}", name, vozrast(), Fakultet);
        }
    }
    class Student : Person
    {
        public string Fakultet;
        public int Kurs;
        public Student(string name, int data, string Fakultet, int Kurs) : base(name, data)
        {
            this.Fakultet = Fakultet;
            this.Kurs = Kurs;
        }
        private int vozrast()
        {
            return 2022 - data;
        }
        public override void Display()
        {
            Console.WriteLine("Information:{0},{1},{2},{3}", name, vozrast(), Fakultet, Kurs);
        }
    }
    class Prepodavatel : Person
    {
        public string Fakultet;
        public string Doljnost;
        public int staj;
        public Prepodavatel(string name, int data, string Fakultet, string Doljnost, int staj) : base(name, data)
        {
            this.Fakultet = Fakultet;
            this.Doljnost = Doljnost;
            this.staj = staj;
        }
        private int vozrast()
        {
            return 2022 - data;
        }
        public override void Display()
        {
            Console.WriteLine("Information:{0},{1},{2},{3},{4}", name, vozrast(), Fakultet, Doljnost, staj);
        }
    }
    class Catalog
    {
        public List<Person> list = new List<Person>();
        public void Person(Person edit)
        {
            list.Add(edit);
        }
        public void Find1(int poisk)
        {
            foreach (var p in list.FindAll(p => 2022 - p.data == poisk))
                p.Display();
        }
    }
    class program
    {
        static void Main(string[] agrs)
        {
            Catalog c = new Catalog();
            Console.WriteLine("введите количество Абитуриентов");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("введите фамилию");
                string name = Console.ReadLine();
                Console.WriteLine("введите год рождения");
                int data = int.Parse(Console.ReadLine());
                Console.WriteLine("факультет");
                string Fakultet = Console.ReadLine();
                c.Person(new Abiturient(name, data, Fakultet));
            }
            Console.WriteLine("введите количество Студентов");
            int s = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("введите фамилию");
                string name = Console.ReadLine();
                Console.WriteLine("год рождения");
                int data = int.Parse(Console.ReadLine());
                Console.WriteLine("факультет");
                string Fakultet = Console.ReadLine();
                Console.WriteLine("курс");
                int Kurs = int.Parse(Console.ReadLine());
                c.Person(new Student(name, data, Fakultet, Kurs));
            }
            Console.WriteLine("введите количество преподавателей");
            int e = int.Parse(Console.ReadLine());
            for (int i = 0; i < e; i++)
            {
                Console.WriteLine("введите фамилию");
                string name = Console.ReadLine();
                Console.WriteLine("год рождения");
                int data = int.Parse(Console.ReadLine());
                Console.WriteLine("факультет");
                string Fakultet = Console.ReadLine();
                Console.WriteLine("должность");
                string Doljnost = Console.ReadLine();
                Console.WriteLine("стаж");
                int staj = int.Parse(Console.ReadLine());
                c.Person(new Prepodavatel(name, data, Fakultet, Doljnost, staj));
            }
            Console.WriteLine("введите возраст для поиска персон");
            int poisk = int.Parse(Console.ReadLine());
            c.Find1(poisk);
            foreach (var p in c.list)
            {
                p.Display();
            }
            Console.ReadLine();
        }
    }
}
