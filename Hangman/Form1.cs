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
using System.Runtime.CompilerServices;

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

        public string Word;
        public string hiddenWord;

        
        public int HighScore;
        
        
        public int CurrentScore;

        public bool GameWon;
        public bool GameLost;

        public Form1()
        {
            InitializeComponent();
            InitializeHighScore();
            Intialize_Game();

            
        }
        

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
                if(letter >= 'A' && letter <= 'Z' || letter >= 'a' && letter <= 'z')
                {

                    if (letter >= 'A' && letter <= 'Z')
                        letter += ' ';

                    if (!Is_Guessed_Letter(letter))
                    {
                        if (Word.ToLower().IndexOf(letter) < 0)
                        {
                            guessedLetters.AppendText(letter.ToString() + " ");
                            try
                            {
                                LoadFrame(Frame[frameIndex++]);
                            }catch
                            {
                                Game_Over();
                                break;
                            }
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
            for(int i=0; i<letters.Length; i++)
            {
                if (letters[i] == '\t')
                {
                    temp[i*2] = letter;
                }
            }
            hiddenWord = new string(temp);
            guessedWord.Text = hiddenWord;
        }

        private bool Is_Guessed_Letter(char letter)
        {
            string content = guessedLetters.Text;
            for(int i=0; i<content.Length; i += 2)
            {
                if (content[i] == letter) return true;
            }
            return false;
        }


        private void Intialize_Game()
        {

            gameOverText.Visible = false;
            guessBtn.Visible = false;
            input.Visible = false;  
            guessedWord.Visible = false;
            mainFrame.Visible = false;
            guessedLetters.Visible = false;
            guessedLettersLabel.Visible = false;
            menuBtn.Visible = false;
            continueBtn.Visible = false;
            errorLabel.Visible = false;

            startBtn.Visible = true;
            quitBtn.Visible = true;

            highScoreLabel.Text = "High score: " + HighScore.ToString();
            GameLost = false;
            GameWon = false;
            CurrentScore = 0;
        }

        private void LoadFrame(string frame)
        {
            mainFrame.ImageLocation = frame;
            mainFrame.Load();
        }

        private void Start_Game(object sender, EventArgs e)
        {
            frameIndex = 0;
            guessBtn.Visible = true;
            input.Visible = true;
            guessedWord.Visible = true;
            mainFrame.Visible = true;
            guessedLettersLabel.Visible = true;
            guessedLetters.Visible = true;
            menuBtn.Visible = true;

            startBtn.Visible = false;
            quitBtn.Visible = false;
            continueBtn.Visible = false;

            if (!GameWon && !GameLost)
                CurrentScore = 0;
            highScoreLabel.Text = "Current score: " + CurrentScore.ToString();

            GameLost = false;
            GameWon = false;

            input.Text = string.Empty;
            guessedLetters.Text = string.Empty;


            LoadFrame(Frame[frameIndex++]);
            Word = Get_Random_Word();
            hiddenWord = Hide_Word(Word);
          

            guessedWord.Text = hiddenWord;
        }

        private bool Has_Won()
        {
            for(int i=0; i< hiddenWord.Length; i += 2)
            {
                if (hiddenWord[i] != Word[i/2])
                    return false;
            }
            return true;
        }

        private void Game_Won()
        {
            gameOverText.Visible = true;
            gameOverText.Text = "You Won!";
            guessBtn.Visible = false;
            input.Visible = false;
            mainFrame.Visible = false;
            guessedLetters.Visible = false;
            guessedLettersLabel.Visible = false;
            menuBtn.Visible = false;

            startBtn.Text = "New Game";
            startBtn.Visible = true;
            quitBtn.Visible = true;
            GameWon = true;
            CurrentScore++;

            highScoreLabel.Text = "Current score: " + CurrentScore.ToString();
        }

        private void Game_Over()
        {
            gameOverText.Visible = true;
            gameOverText.Text = "Game Over!";
            guessBtn.Visible = false;
            input.Visible = false;
            mainFrame.Visible = false;
            guessedLetters.Visible = false;
            guessedLettersLabel.Visible = false;
            menuBtn.Visible = false;

            startBtn.Text = "Try again";
            startBtn.Visible = true;
            quitBtn.Visible = true;

            if(CurrentScore > HighScore)
            {
                HighScore = CurrentScore;
                StreamWriter sw = new StreamWriter(".\\data.dat", false);
                sw.Write(encode(HighScore));
                sw.Close();
            }

            CurrentScore = 0;
            GameLost = true;
            highScoreLabel.Text = "High score: " + HighScore.ToString();

            char[] answer = new char[Word.Length * 2];

            for(int i=0; i<Word.Length; i++)
            {
                answer[2 * i] = Word[i];
                answer[2 * i + 1] = ' ';
            }
            guessedWord.Text = "Answer: " + new string(answer);
        }

        private void Quit(object sender, EventArgs e)
        {
            if (CurrentScore > HighScore)
            {
                HighScore = CurrentScore;
                StreamWriter sw = new StreamWriter(".\\data.dat", false);
                sw.Write(encode(HighScore));
                sw.Close();
            }

            System.Windows.Forms.Application.Exit();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            if (CurrentScore > HighScore)
            {
                HighScore = CurrentScore;
                StreamWriter sw = new StreamWriter(".\\data.dat", false);
                sw.Write(encode(HighScore));
                sw.Close();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            gameOverText.Visible = false;
            guessBtn.Visible = false;
            input.Visible = false;
            guessedWord.Visible = false;
            mainFrame.Visible = false;
            guessedLetters.Visible = false;
            guessedLettersLabel.Visible = false;
            menuBtn.Visible = false;
            startBtn.Visible = true;
            quitBtn.Visible = true;
            continueBtn.Visible = true;

            startBtn.Text = "New Game";

            highScoreLabel.Text = "High score: " + HighScore.ToString();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            gameOverText.Visible = true;
            guessBtn.Visible = true;
            input.Visible = true;
            guessedWord.Visible = true;
            mainFrame.Visible = true;
            guessedLetters.Visible = true;
            guessedLettersLabel.Visible = true;
            menuBtn.Visible = true;

            startBtn.Visible = false;
            quitBtn.Visible = false;
            continueBtn.Visible = false;

            highScoreLabel.Text = "Current score: " + CurrentScore.ToString();
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
        }

        private void InitializeHighScore()
        {
            StreamReader sr = new StreamReader(".\\data.dat");
            string score = sr.ReadLine();
            sr.Close();
            if (score == "" || score == null)
                HighScore = 0;
            else    
                HighScore = decode(score);
            
        }

       private string encode(int source)
       {

            char[] buffer = (~source).ToString().ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
                buffer[i] -= '0';

            return new string(buffer);

       }

       private int decode(string source) {

            char[] buffer = source.ToCharArray();
            for(int i=0; i< buffer.Length; i++)
                buffer[i] += '0';

            int result = ConvertChartoInt32(buffer);

            return ~result;
       }

        private int ConvertChartoInt32(char[] chars)
        {
            int interger = 0;
            for(int i=1; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
                interger *= 10;
                interger += (chars[i]-'0');
               
            }
            Console.WriteLine(chars);
            Console.WriteLine(interger);
            if (chars[0] == '-')
                interger *= -1;

            Console.WriteLine(interger);

            return interger;
        }
    }
}
