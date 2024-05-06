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
        }

        private void Quit(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
