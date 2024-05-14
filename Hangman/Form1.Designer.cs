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
            this.submitBtn = new System.Windows.Forms.Button();
            this.gameOverText = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.mainFrame = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(361, 550);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(98, 35);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
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
            // menuBtn
            // 
            this.menuBtn.CausesValidation = false;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(361, 602);
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
            // mainFrame
            // 
            this.mainFrame.Location = new System.Drawing.Point(231, 12);
            this.mainFrame.Name = "mainFrame";
            this.mainFrame.Size = new System.Drawing.Size(350, 300);
            this.mainFrame.TabIndex = 2;
            this.mainFrame.TabStop = false;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(73, 319);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(596, 79);
            this.questionLabel.TabIndex = 13;
            this.questionLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 648);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.mainFrame);
            this.Controls.Add(this.submitBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.PictureBox mainFrame;
        private System.Windows.Forms.TextBox gameOverText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button quitBtn;
        private Button menuBtn;
        private Button continueBtn;
        private Label questionLabel;
    }
}

