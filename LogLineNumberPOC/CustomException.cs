using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogLineNumberPOC
{
    public class CustomException : Exception
    {
        public CustomException(string message, [CallerFilePath] string file = "",
                        [CallerMemberName] string member = "",
                        [CallerLineNumber] int line = 0) : base(string.Format("Line Number: {0}, Message: {1}, file: {2}, MemberName: {3} ", line, message, file, member))
        {
            
        }
    }
}
