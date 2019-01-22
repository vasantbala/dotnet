using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLineNumberPOC
{
    public class ErrorTest
    {
        public static void ThrowError()
        {
            throw new CustomException("Error occurred.");
        }
    }
}
