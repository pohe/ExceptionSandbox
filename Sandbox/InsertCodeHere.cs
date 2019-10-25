using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //try
            //{
            //    string i = "";
            //    Console.WriteLine("Indtast tal 1:");
            //    i = Console.ReadLine();
            //    int tal1 = Convert.ToInt32(i);

            //    Console.WriteLine("Indtast tal 2:");
            //    i = Console.ReadLine();
            //    int tal2 = Convert.ToInt32(i);
            //    int resultat = tal1 / tal2;
            //    //Console.WriteLine("Resultatet af heltalsdivision er "
            //    //                  + resultat.ToString("n0"));
            //    Console.WriteLine("Resultatet af heltalsdivision er "
            //                      + resultat);
            //}
            //catch (DivideByZeroException dex)
            //{
            //    Console.WriteLine("Hov du dividerede med nul!");
            //}
            //catch (FormatException fex)
            //{
            //    Console.WriteLine("Input er i forkert format!");
            //}
            //catch (OverflowException oex)
            //{
            //    Console.WriteLine("Input tallet er for stort!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Hov der skete en fejl!" + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("I denne blok kommer jeg altid!");
            //}

            Console.WriteLine("Indlæs nummerplade:");
            string regnr = Console.ReadLine();
            Console.WriteLine("Indlæs model");
            string model = Console.ReadLine();

            try
            {
                //Car c = new Car(model);
                //c.Regnr = regnr;
                Car c = new Car(regnr, model);
                //Skal validere regnr i exception
            }
            catch (TooShortRegnrException tex)
            {
                Console.WriteLine(tex.Message);
            }
            catch (MissingCharacterException mex)
            {
                Console.WriteLine(mex.Message);
            }
            //Skal kunne catch exception hvis der mangel A som start bogstav
            
           

            // The LAST line of code should be ABOVE this line
        }
    }
}