namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.mainFrame = new System.Windows.Forms.PictureBox();
            this.guessedWord = new System.Windows.Forms.TextBox();
            this.gameOverText = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(365, 423);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(83, 26);
            this.input.TabIndex = 0;
            // 
            // guessBtn
            // 
            this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBtn.Location = new System.Drawing.Point(355, 482);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(98, 35);
            this.guessBtn.TabIndex = 1;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // mainFrame
            // 
            this.mainFrame.Location = new System.Drawing.Point(231, 12);
            this.mainFrame.Name = "mainFrame";
            this.mainFrame.Size = new System.Drawing.Size(350, 300);
            this.mainFrame.TabIndex = 2;
            this.mainFrame.TabStop = false;
            // 
            // guessedWord
            // 
            this.guessedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedWord.Location = new System.Drawing.Point(284, 367);
            this.guessedWord.MaxLength = 256;
            this.guessedWord.Name = "guessedWord";
            this.guessedWord.ReadOnly = true;
            this.guessedWord.Size = new System.Drawing.Size(255, 26);
            this.guessedWord.TabIndex = 3;
            // 
            // gameOverText
            // 
            this.gameOverText.BackColor = System.Drawing.SystemColors.Window;
            this.gameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.Location = new System.Drawing.Point(258, 107);
            this.gameOverText.MaxLength = 10;
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.ReadOnly = true;
            this.gameOverText.Size = new System.Drawing.Size(295, 68);
            this.gameOverText.TabIndex = 4;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(330, 181);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(138, 73);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.Start_Game);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(330, 274);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(138, 72);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.Quit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 562);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.guessedWord);
            this.Controls.Add(this.mainFrame);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.PictureBox mainFrame;
        private System.Windows.Forms.TextBox guessedWord;
        private System.Windows.Forms.TextBox gameOverText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}

