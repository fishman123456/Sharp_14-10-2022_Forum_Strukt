// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Описать структуру Arcticle, содержащую следующие поля
// код товара, название товара, цену товара.
// Описать перечисление ArcticleType определяющие типы товаров
// и добавить соответствующее поле в структуру Arcticle
// создать меню ввода данных в пустую структуру.
// Описать метод вывода информации на экран
using System.Runtime.Versioning;
using System.Xml;

struct Arcticle
{
    public string id; // код товара
    public string name; // название товара
    public string prise; // цена товара
    public product ios; // структура
    public void Print() // функция вывода
    {
        Console.WriteLine($"Номер {id}, Имя {name}, Цена {prise} ,Тип товара {ios}");
    }
    public void reader() // функция ввода
    {
        Console.WriteLine("Номер\t");
        id = Console.ReadLine();
        Console.WriteLine("Имя\t");
        name = Console.ReadLine();
        Console.WriteLine("Цена\t");
        prise = Console.ReadLine();
        Console.WriteLine("Тип товара 0..2\t");
        ios = (product)int.Parse(Console.ReadLine()); // единственное решение
    }
  
}
  enum product // перечисление типов товара
{
    пиво,
    рыба,
    игрушки
}

class Program
{
    static void Main(string[] args)
    {
       string id = "7", name = "apple", prise = "1000";
        Arcticle d;
        d = new Arcticle();
        d.id = id;
        d.name = name;
        d.prise = prise;
        d.reader();
        d.Print();
    }
}