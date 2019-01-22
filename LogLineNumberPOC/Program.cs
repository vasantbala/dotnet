using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogLineNumberPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ErrorTest.ThrowError();
            }
            catch(Exception ex)
            {
                Log(ex.Message);
            }
        }

        private static void Log(string text)
        {
            Console.WriteLine("Error Message From Exception: {0}", text);
        }
    }
}
