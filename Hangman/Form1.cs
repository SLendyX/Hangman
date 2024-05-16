using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using static Hangman.Form1;
using System.Windows;

namespace Hangman
{
    public partial class Form1 : Form
    {
        //declare variables
        public int frameIndex = 0;
        public string[] Frame =
        {
            ".\\images\\frame_1.png",
            ".\\images\\frame_2.png",
            ".\\images\\frame_3.png",
            ".\\images\\frame_4.png",
            ".\\images\\frame_5.png",
            ".\\images\\frame_6.png",
            ".\\images\\frame_7.png",
        };
        
        public class Question
        {
            string QuestionString;
            string[] Answers;
            bool[] CorrectAnswer;

            public void SetQuestionString(string Question)
            {
                QuestionString = Question;
            }

            public void SetAnswers(string[] AnswersString)
            {
                Answers = AnswersString;
               
            }

            public void SetCorrectAnswers(bool[] CorrectAnswerBools)
            {
                CorrectAnswer = CorrectAnswerBools;
            }

            public string GetQuestion()
            {
                return QuestionString;
            }

            public string[] GetAnswers()
            {
                return Answers;
            }

            public bool[] GetCorrectAnswers()
            {
                return CorrectAnswer;
            }
        }

        public List<Question> Questions = new List<Question>();       
        public List<CheckBox> cbList = new List<CheckBox>();
        public int listIndex = 7;
        public bool[] answers = new bool[9];
        public int totalCorrect = 0;

        Screen display = Screen.PrimaryScreen;

        
        public Form1()
        {
            Location = new Point(display.Bounds.Width/3, display.Bounds.Height/4);
            InitializeComponent();
            Intialize_Game();
        }

        
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!cbList[0].AutoCheck)
                return;

            int i = 0;
            bool[] answers = Questions[listIndex-1].GetCorrectAnswers();
            bool correct = true;
            foreach(CheckBox cb in cbList)
            {
                if (cb.Checked)
                {
                    if (answers[i])
                    {
                        cb.ForeColor = Color.Green;
                    }
                    else
                    {
                        cb.ForeColor = Color.Red;
                        correct = false;
                    }
                    cb.Checked = false;
                }
                else
                {
                    if (answers[i])
                    {
                        cb.ForeColor = Color.OrangeRed;
                        correct = false;
                    }
                }

                if (answers[i])
                    cb.Text += "-(A)";
                else
                    cb.Text += "-(F)";

                cb.AutoCheck = false;
                i++;
            }

            if (!correct)
                LoadFrame(Frame[frameIndex++]);
            else
                totalCorrect++;

            nextBtn.Enabled = true;
            submitBtn.Enabled = false;
        }


        private void InitializeList()
        {
            for (int i = 0; i< 7;i++)
            {
                Questions.Add(new Question { });
            }

            StreamReader sr = new StreamReader(".\\input\\Raspunsuri_quiz_PA.txt");
            foreach (Question question in Questions)
            {
                string line = sr.ReadLine();
                string[] section = line.Split(';');
                string[] answers = new string [section.Length - 1];
                question.SetQuestionString(section[0]);

                for(int i=1; i< section.Length; i++)
                {
                    answers[i-1] = section[i];
                }

                question.SetAnswers(answers);
            }

            foreach (Question question in Questions)
            {
                string line = sr.ReadLine();
                string[] lineToArray = line.Split(' ');
                bool[] bools = new bool[lineToArray.Length];


                for (int i = 0; i < lineToArray.Length; i++)
                {
                    int temp = Convert.ToInt32(lineToArray[i]);
                    bools[i] = Convert.ToBoolean(temp);
                }
                
                question.SetCorrectAnswers(bools);
            }
                sr.Close();          
        }


        private void Intialize_Game()
        {
            Size = new Size(400, 400);
            InitializeList();

            BackgroundImage = System.Drawing.Image.FromFile(".\\images\\back.png");
            submitBtn.Visible = false;
            mainFrame.Visible = false;
            questionLabel.Visible = false;
            procentLabel.Visible = false;
            nextBtn.Visible = false;
            menuBtn.Visible = false;
            continueBtn.Visible = false;
            legendBox.Visible = false;
            secretLabel.Visible = false;

            startBtn.Visible = true;
            quitBtn.Visible = true;
        }

        private void LoadFrame(string frame)
        {
            mainFrame.ImageLocation = frame;
            mainFrame.Load();
        }

        private void LoadQuestion(Question question)
        {
            questionLabel.Text = question.GetQuestion()+":";
        }

        private void LoadAnswers(Question question)
        {   
            int x = questionLabel.Location.X+30;
            int y = questionLabel.Location.Y;
            questionLabel.Size = new Size(874, 40);

            int increment = 70;
            int sizeOffset = 80;
            int initialOffset = 30;
            if (listIndex == Questions.Count)
            {
                y += 90;

                increment = 40;
                sizeOffset = 40;
                initialOffset = 5;
                questionLabel.Location = new Point(30, 440);
                questionLabel.Size = new Size(874, 90);
            }

            if(listIndex == 4)
            {
                questionLabel.Size = new Size(874, 60);
                initialOffset = 40;
            }

            string[] answers = question.GetAnswers();
            List<CheckBox> cb = new List<CheckBox>();
            for (int i = 0; i < answers.Length; i++)
            {
                if (i == 0)
                    y += initialOffset;
                else
                    y+= increment;

                cb.Add(new CheckBox());
                cb[i].TextAlign = ContentAlignment.MiddleLeft;
                cb[i].Font = new Font("Dutch801 Rm BT", 11, FontStyle.Regular);
                cb[i].Text = answers[i];
                cb[i].Location = new Point(x, y);
                cb[i].AutoSize = false;
                cb[i].Size = new Size(763, sizeOffset);
                cb[i].BackColor = Color.Transparent;
                cb[i].Click += new EventHandler(Set_Submit);

                this.Controls.Add(cb[i]);
            }

            cbList = cb;
        }

        private void Set_Submit(object sender, EventArgs e)
        {
            foreach (CheckBox cb in cbList)
            {
                if (cb.Checked)
                {
                    submitBtn.Enabled = true;
                    return;
                }
            }
            submitBtn.Enabled = false;
        }

        private void Start_Game(object sender, EventArgs e)
        {
            frameIndex = 0;
            listIndex = 0;
            totalCorrect = 0;

            Location = new Point(display.Bounds.Width/5, display.Bounds.Height/16);


            BackgroundImage = System.Drawing.Image.FromFile(".\\images\\back6.png");

            foreach (CheckBox cb in cbList)
            {
                this.Controls.Remove(cb);
            }
            cbList.Clear();

            legendBox.Visible = true;
            submitBtn.Visible = true;
            submitBtn.Enabled = false;
            questionLabel.Visible = true;

            mainFrame.Visible = true;
            nextBtn.Visible = true;
            nextBtn.Enabled = false;
            menuBtn.Visible = true;

            startBtn.Visible = false;
            quitBtn.Visible = false;
            continueBtn.Visible = false;
            gameOverText.Visible = false;
            procentLabel.Visible = false;


            Size = new Size(944, 948);

            LoadQuestion(Questions[listIndex]);
            LoadAnswers(Questions[listIndex++]);
            LoadFrame(Frame[frameIndex++]);

            mainFrame.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Game_Won()
        {
            submitBtn.Visible = false;
            nextBtn.Visible = false;
            legendBox.Visible = false;
            mainFrame.Visible = false;

            double score = ((double)((int)((double)(totalCorrect) / 7 * 10000)) / 100);

            if (score == 100)
            {
                secretLabel.Visible = true;
                procentLabel.Location = new Point(316, 100);
            }
            else
            {
                startBtn.Visible = true;
            }

            procentLabel.Text = "Score: " + score.ToString() + "%";
            procentLabel.Visible = true;

            menuBtn.Visible = false;

            startBtn.Text = "Try again";
            
            quitBtn.Visible = true;
        }

        private void Game_Over()
        {
            foreach (CheckBox cb in cbList)
            {
                this.Controls.Remove(cb);
            }
            cbList.Clear();

            questionLabel.Text = string.Empty;

            gameOverText.Visible = true;
            gameOverText.Text = "Game Over!";
            submitBtn.Visible = false;
            nextBtn.Visible = false;
            legendBox.Visible = false;
            mainFrame.Visible = false;

            menuBtn.Visible = false;

            startBtn.Text = "Try again";
            startBtn.Visible = true;
            quitBtn.Visible = true;
        }

        private void Quit(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Menu_Click(object sender, EventArgs e)
        {

            gameOverText.Visible = false;
            submitBtn.Visible = false;
            legendBox.Visible = false;
            mainFrame.Visible = false;
            nextBtn.Visible = false;
            menuBtn.Visible = false;
            questionLabel.Visible = false;

            foreach (CheckBox cb in cbList)
            {
                cb.Visible = false;
            }

            quitBtn.Visible = true;
            continueBtn.Visible = true;
        }

        private void Continue_Click(object sender, EventArgs e)
        {

            gameOverText.Visible = false;
            submitBtn.Visible = true;
            nextBtn.Visible = true;
            mainFrame.Visible = true;
            questionLabel.Visible = true;
            menuBtn.Visible = true;
            legendBox.Visible = true;

            foreach (CheckBox cb in cbList)
            {
                cb.Visible = true;
            }

            Size = new Size(944, 954);

            quitBtn.Visible = false;
            continueBtn.Visible = false;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (frameIndex == Frame.Length)
            {
                Game_Over();
                return;
            }

            nextBtn.Enabled = false;
            submitBtn.Enabled = false;
            foreach (CheckBox cb in cbList)
            {
                this.Controls.Remove(cb);
            }
            cbList.Clear();

            questionLabel.Text = string.Empty;

            if (listIndex == Questions.Count)
            {
                Game_Won();
                return;
            }

            LoadQuestion(Questions[listIndex]);
            LoadAnswers(Questions[listIndex++]);
        }
    }
}
