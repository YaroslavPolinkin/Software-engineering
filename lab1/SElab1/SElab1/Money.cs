using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    internal class Money
    {
        public int intPart { get; set; }
        public int doublePart { get; set; }

        public Money(int intPart, int doublePart)
        {
            this.intPart = intPart;
            this.doublePart = doublePart;
         
        }
  

        //methods
        public void ChangeValue(int IntPart, int DoublePart)
        {

            intPart = IntPart;
            doublePart = DoublePart;

            while (doublePart >= 100)
            {
                doublePart -= 100;
                intPart++;
            }

            while (doublePart < 0)
            {
                doublePart += 100;
                intPart--;
            }

        }

        public string ShowBalance()
        {
            return intPart + "," + doublePart;
        }



    }
}
