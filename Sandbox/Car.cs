using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Car
    {
        private string _regNr;

        public string Regnr
        {
            get { return _regNr; }
            set { _regNr = value; }
        }

        public string Model { get; set; }

        public Car(string model)
        {
            Model = model;
        }

        public Car(string regNr, string model)
        {
            _regNr = regNr;
            Model = model;
        }

        public override string ToString()
        {
            return "Model " + Model + " regnr " + Regnr;
        }
        
    }
}
