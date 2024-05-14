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
        public int listIndex = 0;
        public bool[] answers = new bool[9];

        public Form1()
        {
            InitializeComponent();
            Intialize_Game();
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
            

            

            foreach (Question a in Questions)
            {
                Console.WriteLine(a.GetQuestion());


                string[] answers = a.GetAnswers();
                for (int i=0; i<answers.Length; i++)
                {
                    Console.WriteLine($"{i} {answers[i]}");
                }
            }
        }


        private void Intialize_Game()
        {
            InitializeList();

            gameOverText.Visible = false;
            submitBtn.Visible = false;
            mainFrame.Visible = false;
            questionLabel.Visible = false;

            menuBtn.Visible = false;
            continueBtn.Visible = false;


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
            int x = questionLabel.Location.X;
            int y = questionLabel.Location.Y;
            string[] answers = question.GetAnswers();
            for (int i = 0; i < answers.Length; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = answers[i];
                cb.Location = new Point(x, y + 30 * i);
                this.Controls.Add(cb);
            }
        }


        private void Start_Game(object sender, EventArgs e)
        {
            frameIndex = 0;
            submitBtn.Visible = true;
            questionLabel.Visible = true;

            mainFrame.Visible = true;

            menuBtn.Visible = true;

            startBtn.Visible = false;
            quitBtn.Visible = false;
            continueBtn.Visible = false;

            LoadQuestion(Questions[listIndex]);
            LoadAnswers(Questions[listIndex++]);
            LoadFrame(Frame[frameIndex++]);
        }






        private void Game_Won()
        {
            gameOverText.Visible = true;
            gameOverText.Text = "You Won!";
            submitBtn.Visible = false;

            mainFrame.Visible = false;

            menuBtn.Visible = false;

            startBtn.Text = "New Game";
            startBtn.Visible = true;
            quitBtn.Visible = true;
        }

        private void Game_Over()
        {
            gameOverText.Visible = true;
            gameOverText.Text = "Game Over!";
            submitBtn.Visible = false;

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

            mainFrame.Visible = false;

            menuBtn.Visible = false;
            startBtn.Visible = true;
            quitBtn.Visible = true;
            continueBtn.Visible = true;

            startBtn.Text = "New Game";

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            gameOverText.Visible = true;
            submitBtn.Visible = true;

            mainFrame.Visible = true;

            menuBtn.Visible = true;

            startBtn.Visible = false;
            quitBtn.Visible = false;
            continueBtn.Visible = false;
        }


/*
        private void GuessBtn_Click(object sender, EventArgs e)
        {
            Check_Letter_in_Word();
        }

        private void Input_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Check_Letter_in_Word();
            }
        }

        private void Check_Letter_in_Word()
        {
            errorLabel.Visible = false;

            string letters = input.Text;
            input.Text = string.Empty;

            char letter;
            for (int i = 0; i < letters.Length; i++)
            {
                letter = letters[i];
                if (letter >= 'A' && letter <= 'Z' || letter >= 'a' && letter <= 'z')
                {

                    if (letter >= 'A' && letter <= 'Z')
                        letter += ' ';

                    if (!Is_Guessed_Letter(letter))
                    {
                        if (Word.ToLower().IndexOf(letter) < 0)
                        {
                            guessedLetters.AppendText(letter.ToString() + " ");
                            LoadFrame(Frame[frameIndex++]);
                        }
                        else
                        {
                            Unhide_Letter(letter);
                        }

                        if (frameIndex == Frame.Length)
                        {
                            Game_Over();
                            break;
                        }
                        else if (Has_Won())
                        {
                            Game_Won();
                        }
                    }
                }
                else
                {
                    errorLabel.Text = "*Input must be a valid letter [A-Za-z]";
                    errorLabel.Visible = true;
                    break;
                }
            }
        }

        private void Unhide_Letter(char letter)
        {
            if (letter >= 'A' && letter <= 'Z')
                letter += ' ';


            string letters = Word.ToLower().Replace(letter, '\t');
            char[] temp = hiddenWord.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == '\t')
                {
                    temp[i * 2] = letter;
                }
            }
            hiddenWord = new string(temp);
            guessedWord.Text = hiddenWord;
        }

        private bool Is_Guessed_Letter(char letter)
        {
            string content = guessedLetters.Text;
            for (int i = 0; i < content.Length; i += 2)
            {
                if (content[i] == letter) return true;
            }
            return false;
        }



        private string Get_Random_Word()
        {
            StreamReader sr = new StreamReader(".\\input\\cuvinte.txt");
            string word = sr.ReadLine();

            int lineNumber = 0;
            Random rd = new Random();
            int index = rd.Next(0, 2308);

            while(word != null)
            {

                if (lineNumber == index)
                    return word;
                lineNumber++;
                word = sr.ReadLine();
            }
            return string.Empty;
        }

        private string Hide_Word(string word)
        {
            char[] chars = word.ToCharArray();
            char[] newchars = new char[chars.Length * 2];
            int j = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (chars[i] != ' ')
                {
                    if (i == 0 || i == word.Length - 1)
                    {
                        newchars[j++] = chars[i];
                        newchars[j++] = ' ';
                        continue;
                    }

                    newchars[j++] = '_';
                }
                newchars[j++] = ' ';
            }

            return new string(newchars);
        }*/
    }
}
