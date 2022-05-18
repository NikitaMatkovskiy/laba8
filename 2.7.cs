using System;
using System.Collections.Generic;
abstract class Tovar
{
    public string Name;
    public int Years;
    public Tovar(string Name, int Years)
    {
        this.Name = Name;
        this.Years = Years;
    }
    public abstract void Display();
}
class Igrushka : Tovar //название, цена, производитель, материал, возраст на который рассчитана
{
    public int Cena;
    public string Proizvoditel;
    public string Material;
    public Igrushka(string Name, int Cena, string Proizvoditel, string Material, int Years) : base(Name, Years)
    {
        this.Cena = Cena;
        this.Proizvoditel = Proizvoditel;
        this.Material = Material;
    }
    public override void Display()
    {
        Console.WriteLine(":{0},{1},{2},{3},{4}", Name, Cena, Proizvoditel, Material, Years);
    }
}
class Kniga : Tovar //(название, автор, цена, издательство, возраст на который рассчитана
{
    public string Avtor;
    public int Cena;
    public string Izdatelstvo;
    public Kniga(string Name, string Avtor, int Cena, string Izdatelstvo, int Years) : base(Name, Years)
    {
        this.Avtor = Avtor;
        this.Cena = Cena;
        this.Izdatelstvo = Izdatelstvo;
    }
    public override void Display()
    {
        Console.WriteLine("Information:{0},{1},{2},{3},{4}", Name, Avtor, Cena, Izdatelstvo, Years);
    }
}
class Sport : Tovar //название, цена, производитель, возраст на который рассчитан
{
    public int Cena;
    public string Proizvoditel;
    public Sport(string Name, int Cena, string Proizvoditel, int Years) : base(Name, Years)
    {
        this.Cena = Cena;
        this.Proizvoditel = Proizvoditel;
    }
    public override void Display()
    {
        Console.WriteLine("Information:{0},{1},{2},{3}", Name, Cena, Proizvoditel, Years);
    }
}
class Catalog
{
    public List<Tovar> list = new List<Tovar>();
    public void Tovar(Tovar edit)
    {
        list.Add(edit);
    }
    public void FindEdition(int poisk)
    {
        foreach (var p in list.FindAll(p => p.Years == poisk))
            p.Display();
    }
}
class program
{
    static void Main(string[] agrs)
    {
        Catalog c = new Catalog();
        Console.WriteLine("введите количество игрушек");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("введите название игрушки");
            string Name = Console.ReadLine();
            Console.WriteLine("введите цену");
            int Cena = int.Parse(Console.ReadLine());
            Console.WriteLine("введите производителя");
            string Proizvoditel = Console.ReadLine();
            Console.WriteLine("введите Материал");
            string Material = Console.ReadLine();
            Console.WriteLine("возраст на которые расчитан");
            int Years = int.Parse(Console.ReadLine());
            c.Tovar(new Igrushka(Name, Cena, Proizvoditel, Material, Years));
        }
        Console.WriteLine("введите количество книг");
        int s = int.Parse(Console.ReadLine());
        for (int i = 0; i < s; i++)
        {
            Console.WriteLine("введите название книги");
            string Name = Console.ReadLine();
            Console.WriteLine("введите фамилию автора");
            string Avtor = Console.ReadLine();
            Console.WriteLine("введите цену");
            int Cena = int.Parse(Console.ReadLine());
            Console.WriteLine("введите издательство");
            string Izdatelstvo = Console.ReadLine();
            Console.WriteLine("возраст на который книга расчитана");
            int Years = int.Parse(Console.ReadLine());
            c.Tovar(new Kniga(Name, Avtor, Cena, Izdatelstvo, Years));
        }
        Console.WriteLine("введите количество спорт-инвентаря");
        int e = int.Parse(Console.ReadLine());
        for (int i = 0; i < e; i++)
        {
            Console.WriteLine("введите название спортивного инвентаря");
            string Name = Console.ReadLine();
            Console.WriteLine("введите цену");
            int Cena = int.Parse(Console.ReadLine());
            Console.WriteLine("введите производителя");
            string Proizvoditel = Console.ReadLine();
            Console.WriteLine("возраст на который спортивный инвентарь расчитан");
            int Years = int.Parse(Console.ReadLine());
            c.Tovar(new Sport(Name, Cena, Proizvoditel, Years));
        }

        Console.WriteLine("введите возраст для поиска подходящих товаров");
        int poisk = int.Parse(Console.ReadLine());
        c.FindEdition(poisk);
        foreach (var p in c.list)
        {
            p.Display();
        }
        Console.ReadLine();
    }
}
