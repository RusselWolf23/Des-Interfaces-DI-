using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej4
{
    class Horse
    {
        static readonly private object l = new object();
        private static bool flag = true;
        // public bool finished;
        private string name;
        public int initialPosition;
        private ConsoleColor color;
        private static Random rand = new Random();
        public int pos;
        public bool winner;
        public string Name
        {
            set
            {
                name = value;
                // name = String.Format($"[{value}]");
            }
            get
            {
                return name;
            }
        }


        public Horse(string name, int initialPosition, ConsoleColor color)
        {
            Name = name;
            this.initialPosition = initialPosition;
            this.color = color;
            pos = 0;
            winner = false;
        }

        public void restart() // reiniciar posiciones
        {
            flag = true;
            pos = 0;
        }

        public void initialPLace() // estado inicial 
        {
            Console.ForegroundColor = this.color;
            Console.SetCursorPosition(0, initialPosition);
            Console.WriteLine($"[{Name}]");
        }

        public void run() // los caballos corren
        {
            while (flag)
            {
                lock (l)
                {
                    if (flag)
                    {
                        Console.ForegroundColor = this.color;
                        pos += rand.Next(0, 5);
                        Console.SetCursorPosition(pos, initialPosition);
                        Console.Write($"    [{Name[0]}]");

                        /* provocar ganador
                        if (Name=="Epona")
                        {
                            pos += 5;
                        }
                        */

                        if (pos >= 70)
                        {
                            flag = false;
                            winner = true;
                        }

                    }
                }
                Thread.Sleep(200);
            }
        }

    }
}
