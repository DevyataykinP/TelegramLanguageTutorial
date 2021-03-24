using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class AppException : Exception
    {
        public String MethodName { get; set; }
    }
}
