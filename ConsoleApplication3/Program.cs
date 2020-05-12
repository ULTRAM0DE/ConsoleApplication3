using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { };
            while (true)
            {
                Console.WriteLine("Введите  имя  ");
                string name = Console.ReadLine();
                names.Add(name);
                Console.WriteLine("Нажмите  1 что  бы  продолжить 2 что бы  выйти ");

                if (Console.ReadLine() == "2")
                { break; }

            }
            names.Sort();
            names = names.Distinct().ToList();

            foreach(string name in names)
            {
                Console.WriteLine(name);
            

            }
            Console.WriteLine("Всего имен" + names.Count);
            Console.ReadLine();
        }
    }
}
