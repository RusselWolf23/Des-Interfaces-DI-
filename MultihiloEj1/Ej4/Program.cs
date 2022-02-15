using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        // static bool initialized = true;
        static bool repeat = true;
        static char goal = '|';
        static int goalPrint;
        static int goalPosition;

        static void goalLine(Thread[] th)
        {
            goalPrint = 1;
            for (int i = 0; i < th.Length * 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(goalPosition, goalPrint);
                Console.WriteLine(goal);
                goalPrint++;
            }
        }

        public static void Main(string[] args)
        {
            do
            {
                int chosenHorse = 1;
                bool validate;
                goalPrint = 1;
                goalPosition = 76;
                string answer = "";
                int winner = -1;

                Horse[] horses = {
                    new Horse("Spirit", 1, ConsoleColor.Yellow),
                    new Horse("Pegaso", 3, ConsoleColor.White),
                    new Horse("Sombragris", 5, ConsoleColor.DarkGray),
                    new Horse("Epona", 7, ConsoleColor.DarkRed),
                    new Horse("Sardinilla", 9, ConsoleColor.Cyan)};
                Thread[] th = { new Thread(horses[0].run), new Thread(horses[1].run), new Thread(horses[2].run), new Thread(horses[3].run), new Thread(horses[4].run) };


                do // apostar por un caballo
                {
                    for (int i = 0; i < horses.Length; i++)
                    {
                        horses[i].initialPLace();
                        Console.WriteLine(i + 1);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, horses[horses.Length - 1].initialPosition + 3);  // horses[horses.lenght-1]
                    Console.WriteLine("Wellcome!!\nPlace your bet, choose a number");
                    // chosenHorse = Convert.ToInt32(Console.ReadLine());
                    validate = int.TryParse(Console.ReadLine(), out chosenHorse);
                    Console.Clear();
                } while (!validate || chosenHorse < 1 || chosenHorse > 5);


                goalLine(th); // pinta la linea de meta

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, horses[horses.Length - 1].initialPosition + 3);
                Console.WriteLine("Press a key to start"); // mensaje de inicio

                Console.ReadKey();

                Console.Clear();

                goalLine(th);

                Console.Beep(); // pitido inicial

                foreach (Thread hilo in th) // comienza la carrera
                {
                    hilo.Start();

                }
                foreach (Thread hilo in th)
                {
                    hilo.Join();
                }


                foreach (Horse h in horses) // reiniciar posiciones
                {
                    h.restart();
                }

                for (int i = 0; i < horses.Length; i++) // mensaje del resultado de la carrera
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (horses[i].winner)
                    {
                        Console.SetCursorPosition(0, horses[horses.Length - 1].initialPosition + 3);
                        Console.WriteLine(horses[i].Name.ToUpper() + " WINS!!");
                        winner = i + 1;
                    }
                    if (chosenHorse == winner)
                    {
                        Console.WriteLine("Congrats, your horse is THE WINNER!!      ");
                        break;
                    }
                    else
                    {
                        Console.SetCursorPosition(0, horses[horses.Length - 1].initialPosition + 4);
                        Console.WriteLine("Your horse lose... Good luck next time");
                    }
                }

                Console.ReadKey();
                Console.Clear();
                do // Menu de repetición de la carrera
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, horses[horses.Length - 1].initialPosition + 3);
                    Console.WriteLine("Want to bet again ? S/N");
                    try
                    {
                        answer = Console.ReadLine();
                        if (answer.ToUpper() == "S")
                        {
                            repeat = true;
                        }
                        if (answer.ToUpper() == "N")
                        {
                            repeat = false;
                        }
                        if (answer.ToUpper() != "N" && answer.ToUpper() != "S")
                        {
                            throw new FormatException();
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Write S or N please");
                    }
                    Console.Clear();
                } while (answer.ToUpper() != "N" && answer.ToUpper() != "S");

            } while (repeat);

        }
    }
}
