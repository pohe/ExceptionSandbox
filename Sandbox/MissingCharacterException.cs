using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class MissingCharacterException: Exception
    {
        public MissingCharacterException(string message): base(message)
        {
            
        }
    }
}
