namespace _2025._04._12randomguesser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guess = new Button();
            UserGuess = new NumericUpDown();
            label1 = new Label();
            guessLBL = new Label();
            guessCOUNT = new Label();
            LastLBL = new Label();
            lastCOUNT = new Label();
            HighscoreLBL = new Label();
            HighscoreCOUNT = new Label();
            newgameBT = new Button();
            ((System.ComponentModel.ISupportInitialize)UserGuess).BeginInit();
            SuspendLayout();
            // 
            // Guess
            // 
            Guess.Location = new Point(27, 92);
            Guess.Name = "Guess";
            Guess.Size = new Size(75, 23);
            Guess.TabIndex = 0;
            Guess.Text = "Guess!";
            Guess.UseVisualStyleBackColor = true;
            Guess.Click += Guess_Click;
            // 
            // UserGuess
            // 
            UserGuess.Location = new Point(27, 63);
            UserGuess.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UserGuess.Name = "UserGuess";
            UserGuess.Size = new Size(120, 23);
            UserGuess.TabIndex = 1;
            UserGuess.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 37);
            label1.TabIndex = 2;
            label1.Text = "Guess the number!";
            // 
            // guessLBL
            // 
            guessLBL.AutoSize = true;
            guessLBL.Location = new Point(177, 71);
            guessLBL.Name = "guessLBL";
            guessLBL.Size = new Size(84, 15);
            guessLBL.TabIndex = 3;
            guessLBL.Text = "Guesses so far:";
            // 
            // guessCOUNT
            // 
            guessCOUNT.AutoSize = true;
            guessCOUNT.Location = new Point(261, 72);
            guessCOUNT.Name = "guessCOUNT";
            guessCOUNT.Size = new Size(13, 15);
            guessCOUNT.TabIndex = 4;
            guessCOUNT.Text = "0";
            // 
            // LastLBL
            // 
            LastLBL.AutoSize = true;
            LastLBL.Location = new Point(177, 100);
            LastLBL.Name = "LastLBL";
            LastLBL.Size = new Size(64, 15);
            LastLBL.TabIndex = 5;
            LastLBL.Text = "Last guess:";
            // 
            // lastCOUNT
            // 
            lastCOUNT.AutoSize = true;
            lastCOUNT.Location = new Point(243, 100);
            lastCOUNT.Name = "lastCOUNT";
            lastCOUNT.Size = new Size(36, 15);
            lastCOUNT.TabIndex = 6;
            lastCOUNT.Text = "None";
            // 
            // HighscoreLBL
            // 
            HighscoreLBL.AutoSize = true;
            HighscoreLBL.Location = new Point(177, 128);
            HighscoreLBL.Name = "HighscoreLBL";
            HighscoreLBL.Size = new Size(67, 15);
            HighscoreLBL.TabIndex = 7;
            HighscoreLBL.Text = "High score:";
            // 
            // HighscoreCOUNT
            // 
            HighscoreCOUNT.AutoSize = true;
            HighscoreCOUNT.Location = new Point(243, 128);
            HighscoreCOUNT.Name = "HighscoreCOUNT";
            HighscoreCOUNT.Size = new Size(36, 15);
            HighscoreCOUNT.TabIndex = 8;
            HighscoreCOUNT.Text = "None";
            // 
            // newgameBT
            // 
            newgameBT.Location = new Point(27, 134);
            newgameBT.Name = "newgameBT";
            newgameBT.Size = new Size(75, 23);
            newgameBT.TabIndex = 9;
            newgameBT.Text = "New game";
            newgameBT.UseVisualStyleBackColor = true;
            newgameBT.Visible = false;
            newgameBT.Click += newgameBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 169);
            Controls.Add(newgameBT);
            Controls.Add(HighscoreCOUNT);
            Controls.Add(HighscoreLBL);
            Controls.Add(lastCOUNT);
            Controls.Add(LastLBL);
            Controls.Add(guessCOUNT);
            Controls.Add(guessLBL);
            Controls.Add(label1);
            Controls.Add(UserGuess);
            Controls.Add(Guess);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Number Guesser minigame";
            ((System.ComponentModel.ISupportInitialize)UserGuess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guess;
        private NumericUpDown UserGuess;
        private Label label1;
        private Label guessLBL;
        private Label guessCOUNT;
        private Label LastLBL;
        private Label lastCOUNT;
        private Label HighscoreLBL;
        private Label HighscoreCOUNT;
        private Button newgameBT;
    }
}
