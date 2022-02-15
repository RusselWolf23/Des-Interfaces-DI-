using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultihiloEj1
{
    class Program
    {
        public delegate void MyDelegate();
        public static void MenuGenerator(string[] v, MyDelegate[] md)
        {
            int option = 0;
            bool flag = true;
            if (v.Length == md.Length)
            {
                do
                {
                    Console.WriteLine("Choose an option");
                    for (int i = 0; i < v.Length; i++)
                    {
                        Console.WriteLine($"{(i + 1)}.-{v[i]}:");
                    }
                    Console.WriteLine((md.Length + 1) + ".-" + "Exit:");
                    flag = int.TryParse(Console.ReadLine(), out option);
                    if (flag && option >= 1 && option <= v.Length + 1)
                    {
                        if (option == v.Length + 1)
                        {
                            flag = true;
                        }
                        else
                        {
                            md[option - 1]();
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                    Console.ReadKey();
                } while (!flag || option != (v.Length+1));

            }
            else
            {
                Console.WriteLine("El tamaño de los arrays no concuerda");
                Console.ReadKey();
            }

        }

        //static void f1()
        //{
        //    Console.WriteLine("A");
        //}
        //static void f2()
        //{
        //    Console.WriteLine("B");
        //}
        //static void f3()
        //{
        //    Console.WriteLine("C");
        //}

        static void Main(string[] args)
        {
            string[] v = new string[] { "Suma", "Resta", "Mult", "Div" };
            MyDelegate[] options;
            options = new MyDelegate[] {
                new MyDelegate(()=> Console.WriteLine("A")),
                new MyDelegate(()=> Console.WriteLine("B")),
                ()=> Console.WriteLine("C"),
                ()=> Console.WriteLine("D")
            };
            MenuGenerator(v, options);

            // Console.ReadKey();
        }
    }
}
