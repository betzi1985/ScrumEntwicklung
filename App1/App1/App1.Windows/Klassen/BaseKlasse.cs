using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Klassen;

namespace App1
{
    /// <summary>
    /// This is the Baseclass of Testing
    /// </summary>
    abstract class BaseKlasse : INumberCruncher
    {

        public int Number1 {get; private set; }

        public int Number2 {get; private set; }
        
        public abstract int Crunch();

        /// <summary>
        /// The Konstruktor to set the Data
        /// </summary>
        /// <param name="number1">Number1</param>
        /// <param name="number2">Number2</param>
        public BaseKlasse(int number1, int number2)
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }

        public override string ToString()
        {
            return "Number1: " + this.Number1 + " Number2: " + this.Number2;
        }
        
    }
}
