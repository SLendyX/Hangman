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

namespace Hangman
{
    public partial class Form1 : Form
    {

        //declare variables
        public int i = 0;
        public string[] Frame =
        {
            "D:\\Documents\\visual studio\\repos\\Hangman\\images\\frame_1.png",
            "D:\\Documents\\visual studio\\repos\\Hangman\\images\\frame_2.png",
            "D:\\Documents\\visual studio\\repos\\Hangman\\images\\frame_3.png",
            "D:\\Documents\\visual studio\\repos\\Hangman\\images\\frame_4.png",
            "D:\\Documents\\visual studio\\repos\\Hangman\\images\\frame_5.png",
            "D:\\Documents\\visual studio\\repos\\Hangman\\images\\frame_6.png",
            "D:\\Documents\\visual studio\\repos\\Hangman\\images\\frame_7.png",
        };

        public StreamReader sr = new StreamReader("D:\\Documents\\visual studio\\repos\\Hangman\\input\\cuvinte.txt");
        public string Word;
        public string hiddenWord;

        public Form1()
        {
            InitializeComponent();
            Intialize_Game();
        }
   
        private void GuessBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Intialize_Game()
        {
            gameOverText.Visible = false;
            guessBtn.Visible = false;
            input.Visible = false;  
            guessedWord.Visible = false;
            mainFrame.Visible = false;
            startBtn.Visible = true;
            quitBtn.Visible = true;
            Word = string.Empty;
            hiddenWord = string.Empty;
    }

        private void LoadFrame(string Frame)
        {
            mainFrame.ImageLocation = Frame;
            mainFrame.Load();
        }

        private void Start_Game(object sender, EventArgs e)
        {
            guessBtn.Visible = true;
            input.Visible = true;
            guessedWord.Visible = true;
            mainFrame.Visible = true;
            startBtn.Visible = false;
            quitBtn.Visible = false;
            LoadFrame(Frame[i++]);
            Word = Get_Random_Word();
            hiddenWord = Hide_Word(Word);
            guessedWord.Text = hiddenWord;
        }
        private void Quit(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private string Get_Random_Word()
        {
            string word = sr.ReadLine();

            int lineNumber = 0;
            Random rd = new Random();
            int index = rd.Next(0, 2308);
            
            while(word != null)
            {
               // Debug.AppendText(word);
               // Debug.AppendText("\n");

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
            char[] newchars = new char[chars.Length*2];
            int j = 0;

            for(int i=0; i< word.Length; i++)
            {
                if (chars[i] != ' ')
                {
                    newchars[j++] = '_';
                }
                newchars[j++] = ' ';
            }

            return new string(newchars);
        }

    }
}
