using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _2025._04._12randomguesser
{
    

    public static class HighScoreHandler
    {
        public static int GetHighScore()
        {
            using var db = new HighScoreContext();
            var record = db.HighScores.FirstOrDefault(h => h.Id == 1);
            return record?.Best ?? 0;
        }

        public static void UpdateHighScoreIfBetter(int guesses)
        {
            using var db = new HighScoreContext();
            var record = db.HighScores.FirstOrDefault(h => h.Id == 1);

            if (record == null)
            {
                db.HighScores.Add(new HighScore { Id = 1, Best = guesses });
            }
            else if (guesses < record.Best)
            {
                record.Best = guesses;
            }

            db.SaveChanges();
        }
    }

}
