using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine a = new Magazine();
            Magazine b = new Magazine();
            Console.WriteLine(a.ToShortString());
            Console.ReadLine();
            a.Public = "Байкал";
            a.Date = new DateTime(2013, 10, 05);
            a.edit = 2300;
            Console.WriteLine(a.EDIT.ToString());
            Console.ReadLine();
            Article e = new Article(new Person("Бородина","Наталья",new DateTime(1990,02,12)),"Апостол",5);
            Article e1 = new Article(new Person("Молдованова", "Лариса",new DateTime(1990, 10, 11)),"Вести",4.5);
            a.AddArticles(e);
            a.AddArticles(e1);
            Console.WriteLine("СТАТЬИ:");
            Console.WriteLine(a.ToString());
            Console.ReadLine();
            Person et = new Person("Никитенко", "Андрей", new DateTime(1993, 08, 04));
            Person et1 = new Person("Никитин", "Михаил", new DateTime(1980, 03, 04));
            b.AddEditors(et);
            b.AddEditors(et1);
            Console.WriteLine("РЕДАКТОРЫ:");
            Console.WriteLine(b.ToString()+"\n\n");
            Console.WriteLine("КОПИЯ ОБЪЕКТА");
            Console.WriteLine(a.DeepCopy());
            Console.WriteLine("------------------------------------------------------");
            Console.ReadLine();
            Console.WriteLine("CРАВНЕНИЕ ССЫЛОК СЛЕДУЮЩИХ ОБЪЕКТОВ:");
            Console.WriteLine();
            Edition ed1 = new Edition("Домострой",new DateTime(2009, 10, 07),1270);
            Edition ed2 = new Edition("Домострой",new DateTime(2009, 10, 07),1270);
            Console.WriteLine(ed1.ToString()+"\n");
            Console.WriteLine(ed2.ToString()+"\n\n");
            ReferenceEquals((object)ed1, (object)ed2);
            if (ed1 == ed2)
                Console.WriteLine("ВЫВОД: Объекты идентичны"+"\n");
            else 
                Console.WriteLine("ВЫВОД: Объекты не идентичны"+"\n");
            Console.WriteLine("Хэш-код первого объекта: " +"\n"+ ed1.GetHashCode() + "\n"+ "Хэш-код второго объекта: " +"\n"+ ed2.GetHashCode()+"\n\n");
            Console.WriteLine("Введите тираж издания");
            try
            {
                ed1.edit = int.Parse(Console.ReadLine());
            }
            
            catch (FormatException nonedition)
            {
                Console.WriteLine(nonedition.Message);
            }
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ВЫВОД СПИСКА РЕДАКТОРОВ И СТАТЕЙ ЖУРНАЛА НЕКОТОРЫХ ОБЪЕКТОВ" + "\n\n");
            Article[] artic = new Article[2];
            Article ed = new Article(new Person("Никитенко", "Андрей", new DateTime(1993, 08, 04)), "Вечность", 3);
            Article edd = new Article(new Person("Антонов", "Андрей", new DateTime(1990, 07, 03)), "Жизнь", 4.5);
            artic[0] = ed;
            artic[1] = edd;
            ArrayList al = new ArrayList();
            Person etW = new Person("Никитенко","Андрей",new DateTime(1993,08,04));
            Person et1W = new Person("Федоренко","Степан", new DateTime(1980, 03, 04));
            al.Add(etW);
            al.Add(et1W);
            Console.WriteLine(ed.ToString());
            Console.WriteLine(edd.ToString());
            Console.WriteLine("Редактировали");
            Console.WriteLine(etW.ToString());
            Console.WriteLine(et1W.ToString());
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Список статей с рейтингом выше 2");
            foreach (Article i in artic)
                if (i.Rating > 2)
                    Console.WriteLine(i.Title.ToString());
            Console.WriteLine();
            Console.WriteLine("Список статей, в названиях которых есть сочетание 'Жи'");
            foreach (Article i in artic)
            {
                if (i.Title.Contains("Жи"))
                    Console.WriteLine(i.Title.ToString());
            }
            Console.ReadLine();






            
            
            

            




            

        }
    }
}
