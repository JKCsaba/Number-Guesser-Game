using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._04._12randomguesser
{
    internal class Guess
    {
        private int NumberToGuess;
        private int UserNumber;
        private int guesses;
        public int Guesses => guesses;

        private int lastGuess;
        public int LastGuess => lastGuess;


        public Guess(NumberToGuess a)
        {
            guesses = 0;
            NumberToGuess = a.NumberTG;
        }

        public Result NewGuess(UserNumber b)
        {
            guesses++;
            if (b.UNumber == NumberToGuess)
            {
                lastGuess = b.UNumber;
                HighScoreHandler.UpdateHighScoreIfBetter(guesses);
                return Result.Correct;

            }
            else if (b.UNumber < NumberToGuess)
            {
                lastGuess = b.UNumber;
                return Result.TooLow;
            }
            else if (b.UNumber > NumberToGuess)
            {
                lastGuess = b.UNumber;
                return Result.TooHigh;
            }
            else
            {
                lastGuess = b.UNumber;
                return Result.InvalidInput;
            }
        }
    }
}
