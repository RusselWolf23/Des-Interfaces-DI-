using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamEj2
{
    class Program
    {
        public delegate void ExamDelegate();
        public delegate int hacerCuentas(int n1, int n2);
        public static bool ExceptionHandler(ExamDelegate ed)
        {
            try
            {
                

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            ProcessHandler ph = new ProcessHandler();
            //Process[] processes = Process.GetProcesses();
            //const string FORMAT = "{0,20}{1,7}{2,6}";
            //Console.WriteLine(FORMAT, "Name", "PID", "Threads");
            //foreach (Process p in processes)
            //{
            //    Console.WriteLine(FORMAT, p.ProcessName, p.Id, p.Threads.Count);
            //    Thread.Sleep(50);
            //}
            Process p;
            string file;
            Console.WriteLine("Input file name to open");
            file = Console.ReadLine();
            ProcessStartInfo info = new ProcessStartInfo("Notepad",file);
            p = Process.Start(info);

            Console.WriteLine("Id:{0} Name: {1} Module:{2}",p.Id,p.ProcessName, p.MainModule);

            hacerCuentas n = (a, b) => a / b;

            Console.WriteLine("pid:"+ph.MasterOfThreads());
            Console.WriteLine(n(4,2));

            Console.ReadKey();
        }
    }
}
