using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class TooShortRegnrException: Exception
    {
        public TooShortRegnrException(string message): base(message)
        {
            
        }
    }
}
