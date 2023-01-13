using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace DLR
{

    public class Employee
    {
        public string FirstName { get; set; }

        public void Speak()
        {
            Console.WriteLine("Hi, my name is {0}", FirstName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type excelType = Type.GetTypeFromProgID("Excel.Application");
            dynamic excel = Activator.CreateInstance(excelType);

            excel.Workbooks.Add();

            dynamic sheet = excel.ActiveSheet;

            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                sheet.Cells[i + 1, "A"] = processes[i].ProcessName;
                sheet.Cells[i + 1, "B"] = processes[i].Threads.Count;
            }



        }

        private static object GetASpeaker()
        {
            return new Employee { FirstName = "Anthony" };
        }

    }


}

