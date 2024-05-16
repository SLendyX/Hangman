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
            this.gameOverText = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.procentLabel = new System.Windows.Forms.Label();
            this.mainFrame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.legend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.legendBox = new System.Windows.Forms.GroupBox();
            this.secretLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.legendBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Dutch801 XBd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(697, 129);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(98, 35);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // gameOverText
            // 
            this.gameOverText.BackColor = System.Drawing.Color.Transparent;
            this.gameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gameOverText.Location = new System.Drawing.Point(270, 32);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(384, 105);
            this.gameOverText.TabIndex = 4;
            this.gameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startBtn.Font = new System.Drawing.Font("Dutch801 XBd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(393, 140);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(138, 73);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.Start_Game);
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quitBtn.Font = new System.Drawing.Font("Dutch801 XBd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(393, 219);
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
            this.menuBtn.Font = new System.Drawing.Font("Dutch801 XBd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(32, 18);
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
            this.continueBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.continueBtn.Font = new System.Drawing.Font("Dutch801 XBd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Location = new System.Drawing.Point(393, 140);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(138, 73);
            this.continueBtn.TabIndex = 12;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.Continue_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(29, 446);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(874, 105);
            this.questionLabel.TabIndex = 13;
            this.questionLabel.Text = "label1";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Dutch801 XBd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(697, 178);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(98, 35);
            this.nextBtn.TabIndex = 15;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // procentLabel
            // 
            this.procentLabel.BackColor = System.Drawing.Color.Transparent;
            this.procentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procentLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.procentLabel.Location = new System.Drawing.Point(316, 46);
            this.procentLabel.Name = "procentLabel";
            this.procentLabel.Size = new System.Drawing.Size(294, 73);
            this.procentLabel.TabIndex = 16;
            this.procentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainFrame
            // 
            this.mainFrame.BackColor = System.Drawing.Color.Transparent;
            this.mainFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainFrame.Location = new System.Drawing.Point(295, 18);
            this.mainFrame.Name = "mainFrame";
            this.mainFrame.Size = new System.Drawing.Size(329, 322);
            this.mainFrame.TabIndex = 2;
            this.mainFrame.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // legend
            // 
            this.legend.Enabled = false;
            this.legend.Location = new System.Drawing.Point(3, 0);
            this.legend.MaxLength = 0;
            this.legend.Multiline = true;
            this.legend.Name = "legend";
            this.legend.Size = new System.Drawing.Size(226, 82);
            this.legend.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Correct Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Wrong Answer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(4, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Unselected Correct Answer";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox3.Location = new System.Drawing.Point(4, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // legendBox
            // 
            this.legendBox.BackColor = System.Drawing.Color.Transparent;
            this.legendBox.Controls.Add(this.label3);
            this.legendBox.Controls.Add(this.pictureBox1);
            this.legendBox.Controls.Add(this.pictureBox3);
            this.legendBox.Controls.Add(this.label1);
            this.legendBox.Controls.Add(this.label2);
            this.legendBox.Controls.Add(this.pictureBox2);
            this.legendBox.Controls.Add(this.legend);
            this.legendBox.Location = new System.Drawing.Point(18, 300);
            this.legendBox.Margin = new System.Windows.Forms.Padding(0);
            this.legendBox.Name = "legendBox";
            this.legendBox.Padding = new System.Windows.Forms.Padding(0);
            this.legendBox.Size = new System.Drawing.Size(225, 85);
            this.legendBox.TabIndex = 24;
            this.legendBox.TabStop = false;
            // 
            // secretLabel
            // 
            this.secretLabel.AutoSize = true;
            this.secretLabel.BackColor = System.Drawing.Color.Transparent;
            this.secretLabel.Font = new System.Drawing.Font("Dutch801 XBd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretLabel.Location = new System.Drawing.Point(332, 65);
            this.secretLabel.Name = "secretLabel";
            this.secretLabel.Size = new System.Drawing.Size(267, 32);
            this.secretLabel.TabIndex = 25;
            this.secretLabel.Text = "Thanks For Playing!";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 905);
            this.Controls.Add(this.secretLabel);
            this.Controls.Add(this.legendBox);
            this.Controls.Add(this.procentLabel);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.mainFrame);
            this.Controls.Add(this.questionLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hangman";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.legendBox.ResumeLayout(false);
            this.legendBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.PictureBox mainFrame;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button quitBtn;
        private Button menuBtn;
        private Button continueBtn;
        private Label questionLabel;
        private Button nextBtn;
        private Label procentLabel;
        private PictureBox pictureBox1;
        private TextBox legend;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private GroupBox legendBox;
        private Label secretLabel;
    }
}

