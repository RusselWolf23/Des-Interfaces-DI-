using System;
using System.Threading;

namespace Ej6
{
    class Program
    {
        private static readonly object l = new object();
        static readonly private object l2 = new object();
        public static int commonCont = 0;
        public static int indiceDisplay = 0;
        public static Random rdn = new Random();
        private static bool flag = true;
        private static bool exit = false;
        public static string winner="";

        static void Rand1()
        {
            while (flag)
            {
                int n = rdn.Next(11);
                lock (l)
                {
                    if (flag)
                    {
                        Console.SetCursorPosition(1, 1);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("P1:" + n + " ");

                        if (n == 5 || n == 7)
                        {
                            if (exit)
                            {
                                commonCont += 5;
                            }
                            else
                            {
                                exit = true;
                                commonCont++;
                            }
                        }
                        if (commonCont >= 20)
                        {
                            flag = false;
                            winner = "Player 1";
                        }
                    }
                }
                Thread.Sleep(100 * n);
            }
        }

        static void Rand2()
        {
            while (flag)
            {
                int n = rdn.Next(11);
                lock (l)
                {
                    if (flag)
                    {
                        Console.SetCursorPosition(10, 1);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("P2:" + n + " ");
                        if (n == 5 || n == 7)
                        {
                            if (!exit)
                            {
                                commonCont -= 5;
                            }
                            else
                            {
                                exit = false;
                                Monitor.Pulse(l);
                                commonCont--;
                            }
                        }
                        if (commonCont <= -20)
                        {
                            flag = false;
                            winner = "Player 2";
                        }
                    }
                }
                Thread.Sleep(101 * n);
            }
        }

        static void Display()
        {

            char[] dpl = { '|', '/', '-', '\\' };
            while (flag)
            {
                lock (l)
                {
                    if (exit)
                    {
                        Monitor.Wait(l);
                    }
                    Console.SetCursorPosition(20, 1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(dpl[indiceDisplay] + "\n");
                    indiceDisplay++;
                    if (indiceDisplay >= dpl.Length - 1)
                    {
                        indiceDisplay = 0;
                        // exit = false;
                    }

                }
                Thread.Sleep(200);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pulse a key to start");
            Console.ReadKey();
            Console.Clear();
            Thread player1 = new Thread(Rand1);
            Thread player2 = new Thread(Rand2);
            Thread display = new Thread(Display);
            player1.Start();
            player2.Start();
            display.Start();

            while (flag)
            {
                lock (l)
                {
                    Console.SetCursorPosition(10, 3);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Scale Point:" + commonCont + "  ");
                    if (!flag)
                    {
                        Monitor.Pulse(l);
                        Console.SetCursorPosition(20,8);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("The winner is ");
                        Console.BackgroundColor = winner=="Player 1"? ConsoleColor.Red : ConsoleColor.DarkBlue;
                        Console.Write(winner);
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
