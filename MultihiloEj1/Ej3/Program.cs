using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static readonly private object l = new object();
        static bool flag = true;
        static int n = 0;
        //static void incremento()
        //{
        //    while (flag)
        //    {
        //        lock (l)
        //        {
        //            if (n < 100 && flag)
        //            {
        //                Console.ForegroundColor = ConsoleColor.DarkRed;
        //                n++;
        //                Console.WriteLine(n + "/+");
        //                if (n >= 100)
        //                {
        //                    flag = false;
        //                    Console.WriteLine("Incremento wins!");
        //                }
        //            }
        //        }
        //    }

        //    Console.ResetColor();
        //}

        //static void decremento()
        //{
        //    while (flag)
        //    {
        //        lock (l)
        //        {
        //            if (n > -100 && flag)
        //            {
        //                Console.ForegroundColor = ConsoleColor.White;
        //                n--;
        //                Console.WriteLine(n + "/-");
        //                if (n <= -100)
        //                {
        //                    flag = false;
        //                    Console.WriteLine("Decremento wins!");
        //                }
        //            }
        //        }
        //    }

        //    Console.ResetColor();
        //}



        static void Main(string[] args)
        {
            Thread a = new Thread(() =>
            {
                while (flag)
                {
                    lock (l)
                    {
                        if (flag)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            n++;
                            Console.WriteLine(n + "/+");
                            if (n >= 100)
                            {
                                flag = false;
                                Console.WriteLine("Incremento wins!");
                            }
                        }                        
                    }
                }

                Console.ResetColor();

            });
            Thread b = new Thread(() =>
            {
                while (flag)
                {
                    lock (l)
                    {
                        if (flag)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            n--;
                            Console.WriteLine(n + "/-");
                            if (n <= -100)
                            {
                                flag = false;
                                Console.WriteLine("Decremento wins!");
                            }
                        }
                        
                    }
                }
                Console.ResetColor();
            });

            a.Start();
            b.Start();
            a.Join();

            Console.ReadKey();
        }
    }
}
