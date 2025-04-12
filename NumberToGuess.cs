using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._04._12randomguesser
{
    internal class NumberToGuess
    {
        Random r = new Random();
        public int NumberTG { get; private set; }
        public NumberToGuess()
        {
            NumberTG = r.Next(1, 101);
        }


    }
}
