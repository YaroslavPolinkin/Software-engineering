using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class Money
    {
        private int _intPart;
        private int _doublePart;

        public Money(int intPart, int doublePart)
        {
            _doublePart = doublePart;
            _intPart = intPart;

            NormalizeBalance();

        }
  

        //methods
        public void Add(int IntPart, int doublePart)
        {
            _doublePart += doublePart;
            _intPart += IntPart;

            NormalizeBalance();
        }

        public void Subtract(int IntPart, int doublePart)
        {
            _doublePart -= doublePart;
            _intPart -= IntPart;

            NormalizeBalance();

        }


        private void NormalizeBalance()
        {
            while (_doublePart >= 100)
            {
                _doublePart -= 100;
                _intPart++;
            }

            while (_doublePart < 0)
            {
                _doublePart += 100;
                _intPart--;
            }
        }

        public string ShowBalance()
        {

            return $"{_intPart},{_doublePart:D2}";
        }



    }
}
