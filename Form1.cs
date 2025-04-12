namespace _2025._04._12randomguesser
{
    public partial class Form1 : Form
    {
        private Guess g;
        private NumberToGuess ntg;
        public Form1()
        {
            InitializeComponent();
            ntg = new();
            g = new(ntg);
            int score = HighScoreHandler.GetHighScore();
            HighscoreCOUNT.Text = score == 0 ? "None" : $"{score}";
            Guess.Enabled = true;
            newgameBT.Visible = false;
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            Result result = g.NewGuess(new UserNumber((int)UserGuess.Value));
            lastCOUNT.Text = g.LastGuess.ToString();
            guessCOUNT.Text = g.Guesses.ToString();
            switch (result)
            {
                case Result.Correct:
                    MessageBox.Show($"You guessed the number correctly, congrats!\nTotal Guesses: {g.Guesses.ToString()}", "🎉VICTORY🎉", MessageBoxButtons.OK);
                    DialogResult answer = MessageBox.Show("\nDo you want to play an another round?", "TRY AGAIN?", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        ntg = new();
                        g = new(ntg);

                        lastCOUNT.Text = "None";
                        guessCOUNT.Text = "0";
                        UserGuess.Value = 1;
                        Guess.Enabled = true;
                        newgameBT.Visible = false;
                    }
                    else
                    {
                        Guess.Enabled = false;
                        newgameBT.Visible = true;
                    }
                    break;
                case Result.TooLow:
                    MessageBox.Show($"Too Low!\nGuesses so far: {g.Guesses.ToString()}", "TOO LOW");
                    break;
                case Result.TooHigh:
                    MessageBox.Show($"Too High!\nGuesses so far: {g.Guesses.ToString()}", "TOO HIGH");
                    break;
            }
        }

        private void newgameBT_Click(object sender, EventArgs e)
        {
            ntg = new();
            g = new(ntg);

            lastCOUNT.Text = "None";
            guessCOUNT.Text = "0";
            UserGuess.Value = 1;
            Guess.Enabled = true;
            newgameBT.Visible = false;
        }
    }
}
