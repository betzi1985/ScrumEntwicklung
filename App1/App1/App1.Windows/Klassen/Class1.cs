using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Klassen;

namespace App1.Klassen
{
    class Class1 : BaseKlasse
    {
        public Class1(int number1,int number2) : base(number1,number2){}

        public override int Crunch()
        {
            return this.Number1 + this.Number2;
        }
    }
}
