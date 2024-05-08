using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.TextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.mainFrame = new System.Windows.Forms.PictureBox();
            this.gameOverText = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.guessedLetters = new System.Windows.Forms.TextBox();
            this.guessedLettersLabel = new System.Windows.Forms.Label();
            this.guessedWord = new System.Windows.Forms.TextBox();
            this.menuBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AcceptsReturn = true;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(342, 381);
            this.input.MaxLength = 64;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(138, 35);
            this.input.TabIndex = 0;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_Enter);
            // 
            // guessBtn
            // 
            this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBtn.Location = new System.Drawing.Point(361, 449);
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
            // gameOverText
            // 
            this.gameOverText.BackColor = System.Drawing.SystemColors.Window;
            this.gameOverText.Enabled = false;
            this.gameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.Location = new System.Drawing.Point(261, 78);
            this.gameOverText.MaxLength = 10;
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.ReadOnly = true;
            this.gameOverText.Size = new System.Drawing.Size(295, 68);
            this.gameOverText.TabIndex = 4;
            this.gameOverText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(342, 165);
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
            this.quitBtn.Location = new System.Drawing.Point(342, 244);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(138, 72);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.Quit);
            // 
            // guessedLetters
            // 
            this.guessedLetters.Enabled = false;
            this.guessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedLetters.Location = new System.Drawing.Point(56, 357);
            this.guessedLetters.MaxLength = 13;
            this.guessedLetters.Multiline = true;
            this.guessedLetters.Name = "guessedLetters";
            this.guessedLetters.Size = new System.Drawing.Size(93, 32);
            this.guessedLetters.TabIndex = 8;
            this.guessedLetters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guessedLettersLabel
            // 
            this.guessedLettersLabel.AutoSize = true;
            this.guessedLettersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedLettersLabel.Location = new System.Drawing.Point(26, 313);
            this.guessedLettersLabel.Name = "guessedLettersLabel";
            this.guessedLettersLabel.Size = new System.Drawing.Size(154, 25);
            this.guessedLettersLabel.TabIndex = 9;
            this.guessedLettersLabel.Text = "Guessed letters:";
            // 
            // guessedWord
            // 
            this.guessedWord.Enabled = false;
            this.guessedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedWord.Location = new System.Drawing.Point(301, 331);
            this.guessedWord.Name = "guessedWord";
            this.guessedWord.Size = new System.Drawing.Size(220, 35);
            this.guessedWord.TabIndex = 10;
            this.guessedWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuBtn
            // 
            this.menuBtn.CausesValidation = false;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(361, 516);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(98, 34);
            this.menuBtn.TabIndex = 11;
            this.menuBtn.TabStop = false;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.Menu_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Location = new System.Drawing.Point(342, 86);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(138, 73);
            this.continueBtn.TabIndex = 12;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.Continue_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(298, 419);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(85, 17);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "PlaceHolder";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 562);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.guessedWord);
            this.Controls.Add(this.guessedLettersLabel);
            this.Controls.Add(this.guessedLetters);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.mainFrame);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox gameOverText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.TextBox guessedLetters;
        private System.Windows.Forms.Label guessedLettersLabel;
        private TextBox guessedWord;
        private Button menuBtn;
        private Button continueBtn;
        private Label errorLabel;
    }
}

