using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace РГР_по_проге_2_семестр
{
    public class List
    {
        public string subject; // тематику
        public string title; // название книги
        public string methodological; // методических указаний 
        public string editions; // издания
        public string author; // автора 
        public int year; // год издания
        public int quantity; // полное количество страниц
        public string funds; // наличие в фондах (УФ, НФ, ЧЗ) с 
        public int instances; // указанием числа экземпляров
        public List(string subject, string title, string methodological, string editions, string author, int year, int quantity, string funds, int instances)
        {
            this.subject = subject;
            this.title = title;
            this.methodological = methodological;
            this.editions = editions;
            this.author = author;
            this.year = year;
            this.quantity = quantity;
            this.funds = funds;
            this.instances = instances;
        }
        public void Deconstruct(out string osubject,out string otitle,out string omethodological,out string oeditions,out string oauthor,out int oyear,out int oquantity,out string ofunds,out int oinstances)
        {
            osubject = subject;
            otitle = title;
            omethodological = methodological;
            oeditions = editions;
            oauthor = author;
            oyear = year;
            oquantity = quantity;
            ofunds = funds;
            oinstances = instances;
        }
    } 
    class Program
    {
        static void Uzdatel(List[] a, int con) //выборки всех изданий по теме 
        {
            Console.WriteLine("Введите темy книги");
            string search = Console.ReadLine();
            List<string> ter = new List<string>();
            for (int i = 0; i < a.Length; i++)
            {
                (string osubject, string otitle, string omethodological, string oeditions, string oauthor, int oyear, int oquantity, string ofunds, int oinstances) = a[i];
                if (search == osubject)
                {
                    ter.Add(oeditions);
                    con += 1;
                }
            }
            ter.Sort( );
            foreach (string item in ter)
                Console.WriteLine(item);
            if (con == 0)
            {
                Console.WriteLine("Такая тема не найдена в библиотеке");
            }
        }

        static void Teme(List[]a, int con) //Выбор по теме
        {
            Console.WriteLine("Введите тему книги");
            string search = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                (string osubject, string otitle, string omethodological, string oeditions, string oauthor, int oyear, int oquantity, string ofunds, int oinstances)= a[i];
                if (search == osubject)
                {
                    Console.WriteLine($"Тема {osubject}, название книги {otitle}, методических указаний {omethodological}, издания {oeditions}, автора {oauthor}, год издания {oyear}, полное количество страниц {oquantity}, фондах {ofunds}, экземпляров {oinstances}");
                    con += 1;
                }
            }
            if (con == 0)
            {
                Console.WriteLine("Такая тема не найдена в библиотеке.");
            }
        }
        static void Got(List[] a, int con) //Выбор по годам
        {
            Console.WriteLine("Введите год книги.");
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                (string osubject, string otitle, string omethodological, string oeditions, string oauthor, int oyear, int oquantity, string ofunds, int oinstances) = a[i];
                if (search == oyear)
                {
                    Console.WriteLine($"Тема {osubject}, название книги {otitle}, методических указаний {omethodological}, издания {oeditions}, автора {oauthor}, год издания {oyear}, полное количество страниц {oquantity}, фондах {ofunds}, экземпляров {oinstances}");
                    con += 1;
                }
            }
            if (con == 0)
            {
                Console.WriteLine("Такой год не найдена.");
            }
        }
        static void Font(List[] a, int con) //Выбор по наличию в фондах библиотеки
        {
            Console.WriteLine("Введите фонда библиотеки.");
            string search = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                (string osubject, string otitle, string omethodological, string oeditions, string oauthor, int oyear, int oquantity, string ofunds, int oinstances) = a[i];
                if (search == ofunds)
                {
                    Console.WriteLine($"Тема {osubject}, название книги {otitle}, методических указаний {omethodological}, Издания {oeditions}, автора {oauthor}, год издания {oyear}, полное количество страниц {oquantity}, фондах {ofunds}, экземпляров {oinstances}");
                    con += 1;
                }
            }
            if (con == 0)
            {
                Console.WriteLine("Такой фонд библиотеки не найдена.");
            }
        }
        static void Ono() // о программе 
        {
            Console.WriteLine("О программе");
            Console.WriteLine("Программа сформировывает данные 'Тематического списка литературы'.");
            Console.WriteLine("Список включает тематику, название книги, методических указаний или др. издания, автора, год издания, полное количество страниц, наличие в фондах с указанием числа экземпляров.");
            Console.WriteLine("Разработанная программа предусматривает выборки всех изданий по теме в алфавитном порядке; по теме и по годам; по наличию в фондах библиотеки.");
            Console.WriteLine("Автор: Шаханина Дарья (-_-)/");
            Console.WriteLine("_____________________________");
        }
        static void Bxod() //Выход
        {
            Console.Clear();
            Console.WriteLine(" ^ ^             ");
            Console.WriteLine("( . .)  < Чмок!!> ");
            Console.WriteLine("<( )>            ");
            Console.WriteLine(" ! !");
            Environment.Exit(0);
        }
        static void Completion(int n,List[]a)
        {
            string subject;
            string title; 
            string methodological;
            string editions;
            string author;  
            int year; 
            int quantity;
            string funds;
            int instances; 
            for (int i = 1; i < n + 1; i++)
            {
                Console.WriteLine($"Bвод {i} ");
                Console.WriteLine("Введите тематику книги");
                try
                {
                    subject = Console.ReadLine();
                    Console.WriteLine("Введите название книги");
                    title = Console.ReadLine();
                    Console.WriteLine("Введите методических указаний книги");
                    methodological = Console.ReadLine();
                    Console.WriteLine("Введите издания книги");
                    editions = Console.ReadLine();
                    Console.WriteLine("Введите автора книги");
                    author = Console.ReadLine();
                    Console.WriteLine("Введите год издания книги");
                    year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите полное количество страниц ");
                    quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите фондах книги");
                    funds = Console.ReadLine();
                    Console.WriteLine("Введите  числа экземпляров книги");
                    instances = int.Parse(Console.ReadLine());
                    List k = new List(subject, title, methodological, editions, author, year, quantity, funds, instances);
                     a[i - 1] = k;
                }
                catch
                {
                    Console.WriteLine("Неверноый ввод");
                    Console.WriteLine("Пожалуйста введите сначала");
                    Thread.Sleep(1000);
                    Console.Clear();
                    i--;
                }
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            Ono();
            Console.WriteLine("Введите количество тематического списка литературы");
            try
            {
                int n = int.Parse(Console.ReadLine());
                List[] a = new List[n];
                Console.Clear();
                Completion(n, a);
                bool g = true;
                while (g == true)
                {
                    Console.Clear();
                    string[] menu = new string[5] {"Все издания по теме", "Выбор по теме", "Выбор по годам", "Выбор по наличию фонда библиотеки", "Выход" };
                    Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}");
                    Console.SetCursorPosition(40, 0);
                    bool t = true;
                    for (int i = 0; t == true;)
                    {
                        ConsoleKeyInfo op = Console.ReadKey(true);
                        if (op.Key == ConsoleKey.Enter && i == 0)//выборки всех изданий по теме 
                        {
                            Console.Clear();
                            Uzdatel(a,0);
                            Thread.Sleep(3000);
                            t = false;
                        }
                        else if (op.Key == ConsoleKey.Enter && i == 1)//Выбор по теме
                        {
                            Console.Clear();
                            Teme(a,0);
                            Thread.Sleep(3000);
                            t = false;
                        }
                        else if (op.Key == ConsoleKey.Enter && i == 2)//Выбор по годам
                        {
                            Console.Clear();
                            Got(a,0);
                            Thread.Sleep(3000);
                            t = false;
                        }
                        else if (op.Key == ConsoleKey.Enter && i == 3)//Выбор по наличию в фондах библиотеки
                        {
                            Console.Clear();
                            Font(a,0);
                            Thread.Sleep(3000);
                            t = false;
                        }
                        else if (op.Key == ConsoleKey.Enter && i == 4)//Выход
                        {
                            Bxod();
                        }
                        // управление консоли 
                        else if ((op.Key == ConsoleKey.DownArrow && i == 4) || (op.Key == ConsoleKey.UpArrow && i == 1))
                        {
                            Console.SetCursorPosition(40, 0);
                            i = 0;
                        }
                        else if ((op.Key == ConsoleKey.DownArrow && i == 0) || (op.Key == ConsoleKey.UpArrow && i == 2))
                        {
                            Console.SetCursorPosition(40, 1);
                            i = 1;
                        }
                        else if ((op.Key == ConsoleKey.DownArrow && i == 1) || (op.Key == ConsoleKey.UpArrow && i == 3))
                        {
                            Console.SetCursorPosition(40, 2);
                            i = 2;
                        }
                        else if ((op.Key == ConsoleKey.DownArrow && i == 2) || (op.Key == ConsoleKey.UpArrow && i == 4))
                        {
                            Console.SetCursorPosition(40, 3);
                            i = 3;
                        }
                        else if ((op.Key == ConsoleKey.DownArrow && i == 3) || (op.Key == ConsoleKey.UpArrow && i == 0))
                        {
                            Console.SetCursorPosition(40, 4);
                            i = 4;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
                Console.WriteLine("Пожалуйста введите сначала");
                Thread.Sleep(1000);
                Console.Clear();
                Main(args);
            }
        }
    }
}
