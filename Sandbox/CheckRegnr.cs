using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CheckRegnr
    {
        public static bool Valider(string regnr)
        {
            if (regnr.Length < 8)
            {
                throw new TooShortRegnrException("Regnr der for kort - mindst 8 karakterer langt");
            }

            if (!regnr.StartsWith("A"))
            {
                throw new MissingCharacterException("Regnr skal starte med et A");
            }

            return true;
        }

    }


}
