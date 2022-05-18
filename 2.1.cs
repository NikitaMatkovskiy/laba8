using System;
using System.Collections;
using System.Collections.Generic;



abstract class Izdanie
{
    public string Name { get; set; }
    public string FIO { get; set; }
    public Izdanie(string Name, string FIO)
    {
        this.Name = Name;
        this.FIO = FIO;
    }
    public abstract void Display();

}

class Kniga : Izdanie
{
    public int god;
    public string Izdatelstvo;
    public Kniga(string Name, string FIO, int god, string Izdatelstvo) : base(Name, FIO)
    {
        this.god = god;
        this.Izdatelstvo = Izdatelstvo;
    }
    public override void Display()
    {
        Console.WriteLine("Information:{0},{1},{2},{3}", Name, FIO, god, Izdatelstvo);
    }
}
class Statia : Izdanie
{
    public string Naz;
    public int Nomber;
    public int god1;
    public Statia(string Name, string FIO, string Naz, int god1, int Nomber) : base(Name, FIO)
    {
        this.Naz = Naz;
        this.Nomber = Nomber;
        this.god1 = god1;
    }
    public override void Display()
    {
        Console.WriteLine("Information:{0},{1},{2},{3},{4}", Name, FIO, god1, Naz, Nomber);
    }
}
class ElectronRes : Izdanie
{
    public string ssilka;
    public string annotacia;
    public ElectronRes(string Name, string FIO, string ssilka, string annotacia) : base(Name, FIO)
    {
        this.ssilka = ssilka;
        this.annotacia = annotacia;
    }
    public override void Display()
    {
        Console.WriteLine("Information:{0},{1},{2},{3}", Name, FIO, ssilka, annotacia);
    }
}
class Catalog
{
    public List<Izdanie> list = new List<Izdanie>();
    public void AddEdition(Izdanie edit)
    {
        list.Add(edit);
    }
    public void FindEdition(string FIO)
    {
        foreach (var p in list.FindAll(p => p.FIO == FIO))
            p.Display();
    }
}
class program
{
    static void Main(string[] agrs)
    {
        Catalog c = new Catalog();
        ArrayList book = new ArrayList();
        ArrayList article = new ArrayList();
        ArrayList ELres = new ArrayList();
        Console.WriteLine("введите количество книг");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("введите название книги");
            string Name = Console.ReadLine();
            Console.WriteLine("введите фамилию автора");
            string FIO = Console.ReadLine();
            Console.WriteLine("год издания");
            int god = int.Parse(Console.ReadLine());
            Console.WriteLine("введите издательство");
            string Izdatelstvo = Console.ReadLine();
            book.Add(new Kniga(Name, FIO, god, Izdatelstvo));
        }
        Console.WriteLine("введите количество статей");
        int s = int.Parse(Console.ReadLine());
        for (int i = 0; i < s; i++)
        {
            Console.WriteLine("введите название статьи");
            string Name = Console.ReadLine();
            Console.WriteLine("введите фамилию автора");
            string FIO = Console.ReadLine();
            Console.WriteLine("введите название журнала");
            string Naz = Console.ReadLine();
            Console.WriteLine("номер журнала");
            int Nomber = int.Parse(Console.ReadLine());
            Console.WriteLine("год издания");
            int god1 = int.Parse(Console.ReadLine());
            article.Add(new Statia(Name, FIO, Naz, Nomber, god1));
        }
        Console.WriteLine("введите количество электронных ресурсов");
        int e = int.Parse(Console.ReadLine());
        for (int i = 0; i < e; i++)
        {
            Console.WriteLine("введите название электронного ресурса");
            string Name = Console.ReadLine();
            Console.WriteLine("введите фамилию автора");
            string FIO = Console.ReadLine();
            Console.WriteLine("введите ссылку");
            string ssilka = Console.ReadLine();
            Console.WriteLine("введите анотацию");
            string annotacia = Console.ReadLine();
            ELres.Add(new ElectronRes(Name, FIO, ssilka, annotacia));
        }

        Console.WriteLine("введите фамилию автора для поиска по изданию");
        string poisk = Console.ReadLine();
        c.FindEdition(poisk);
        foreach (var p in c.list)
        {
            p.Display();
        }
        Console.ReadLine();
    }
}
