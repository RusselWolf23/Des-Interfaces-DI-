using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEj2
{
    class ProcessHandler
    {        
        public int MasterOfThreads()
        {            
            Process[] procesos = Process.GetProcesses();
            int i = 0;
            foreach (Process p in procesos)
            {
                i = p.Id > i ? p.Id : i;
                
            }

            return i;
        }

        


    }
}
