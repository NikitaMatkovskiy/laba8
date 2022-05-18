using System;
using System.Collections.Generic;
abstract class klient
{
    public string Name;
    public int Data;
    public klient(string Name, int Data)
    {
        this.Data = Data;
        this.Name = Name;
    }
    public abstract void Display();
}
class Vkladchik : klient //фамилия, дата открытия вклада, размер вклада, процент по вкладу
{
    public int RazmerVk;
    public int Procent;
    public Vkladchik(string Name, int Data, int RazmerVk, int Procent) : base(Name, Data)
    {
        this.RazmerVk = RazmerVk;
        this.Procent = Procent;
    }
    public override void Display()
    {
        Console.WriteLine("Information:{0},{1},{2},{3}", Name, Data, RazmerVk, Procent);
    }
}
class Kreditor : klient //фамилия, дата выдачи кредита, размер кредита, процент по кредиту, остаток долга
{    
    public int Razmer;
    public int Procent;
    public int Ostatok;
    public Kreditor(string Name, int Data, int Razmer, int Procent, int Ostatok) : base(Name, Data)
    {
        this.Razmer = Razmer;
        this.Procent = Procent;
        this.Ostatok = Ostatok;
    }
    public override void Display()
    {
        Console.WriteLine("Information:{0},{1},{2},{3},{4}", Name, Data, Razmer, Procent, Ostatok);
    }
}
class Organizacia : klient //название, дата открытия счета, номер счета, сумма на счету
{
    public int Nomber;
    public int Summa;
    public Organizacia(string Name, int Data, int Nomber, int Summa) : base(Name, Data)
    {
        this.Nomber = Nomber;
        this.Summa = Summa;
    }
    public override void Display()
    {
        Console.WriteLine("Information:{0},{1},{2},{3}", Name, Data, Nomber, Summa);
    }
}
class Catalog
{
    public List<klient> list = new List<klient>();
    public void klient(klient edit)
    {
        list.Add(edit);
    }
    public void FindEdition(int poisk)
    {
        foreach (var p in list.FindAll(p => p.Data >= poisk))
            p.Display();
    }
}
class program
{
    static void Main(string[] agrs)
    {
        Catalog c = new Catalog();
        Console.WriteLine("Количество вкладчиков");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("введите Фамилию");
            string Name = Console.ReadLine();
            Console.WriteLine("введите Дата открытия счета");
            int Data = int.Parse(Console.ReadLine());
            Console.WriteLine("введите номер счета");
            int RazmerVk = int.Parse(Console.ReadLine());
            Console.WriteLine("введите сумму на счету");
            int Procent = int.Parse(Console.ReadLine());
            c.klient(new Vkladchik(Name, Data, RazmerVk, Procent));
        }
        Console.WriteLine("введите количество Кредиторов");
        int s = int.Parse(Console.ReadLine());
        for (int i = 0; i < s; i++)
        {
            Console.WriteLine("введите фамилию");
            string Name = Console.ReadLine();
            Console.WriteLine("введите дату выдачи кредита");
            int Data = int.Parse(Console.ReadLine());
            Console.WriteLine("введите размер кредита");
            int Razmer = int.Parse(Console.ReadLine());
            Console.WriteLine("введите процент по кредиту");
            int Procent = int.Parse(Console.ReadLine());
            Console.WriteLine("введите остаток долга");
            int Ostatok = int.Parse(Console.ReadLine());
            c.klient(new Kreditor(Name, Data, Razmer, Procent, Ostatok));
        }
        Console.WriteLine("введите количество Организаций"); 
        int e = int.Parse(Console.ReadLine());
        for (int i = 0; i < e; i++)
        {
            Console.WriteLine("введите название");
            string Name = Console.ReadLine();
            Console.WriteLine("введите дату открытия счета");
            int Data = int.Parse(Console.ReadLine());
            Console.WriteLine("введите номер счета");
            int Nomber = int.Parse(Console.ReadLine());
            Console.WriteLine("введите сумму на счету");
            int Summa = int.Parse(Console.ReadLine());
            c.klient(new Organizacia(Name, Data, Nomber, Summa));
        }

        Console.WriteLine("задайте дату с которой клиенты начали сотрудничать с банком");
        int poisk = int.Parse(Console.ReadLine());
        c.FindEdition(poisk);
        foreach (var p in c.list)
        {
            p.Display();
        }
        Console.ReadLine();
    }
}
