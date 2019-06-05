using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string solutionEasy, solutionNormal, solutionHard;
        int tries = 4, triesHard = 3;
        string firstChar, thirdChar, fifthChar;

        private void button1_Click(object sender, EventArgs e)
        {
            Normalbutton.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            button5.Visible = true;
            textBox1.Visible = false;
            explainationBox.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            buttonEasy.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label1.Visible = true;

            explainationBox.Text = "The word is five letters long. Guess what the word is, you have four tries. Good luck!";

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "easy.txt"));
            Random rand = new Random();
            var randomLineNumber = rand.Next(0, lines.Length - 1);
            string line = lines[randomLineNumber];
            solutionEasy = line;

            firstChar = Convert.ToString(solutionEasy[0]);
            thirdChar = Convert.ToString(solutionEasy[2]);
            fifthChar = Convert.ToString(solutionEasy[4]);
            textBox3.Text = (firstChar + "_" + thirdChar + "_" + fifthChar); //extra letters to make it easier

            textBox6.Text = Convert.ToString(tries);
        }

        private void Normalbutton_Click(object sender, EventArgs e)
        {
            Normalbutton.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            button5.Visible = true;
            buttonNormal.Visible = true;
            textBox1.Visible = false;
            explainationBox.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label1.Visible = true;

            explainationBox.Text = "The word is six letters long. Guess what the word is, you have four tries. Good luck!";

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "normal.txt"));
            Random rand = new Random();
            var randomLineNumber = rand.Next(0, lines.Length - 1);
            string line = lines[randomLineNumber];
            solutionNormal = line;

            firstChar = Convert.ToString(solutionNormal[0]);
            thirdChar = Convert.ToString(solutionNormal[2]);
            textBox3.Text = (firstChar + "_" + thirdChar + "_" + "_" + "_"); //extra letters to make it easier

            textBox6.Text = Convert.ToString(tries);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Normalbutton.Visible = false;
            button5.Visible = true;
            button3.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;
            buttonHard.Visible = true;
            explainationBox.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label1.Visible = true;

            explainationBox.Text = "The word is seven letters long. Guess what the word is, you have three tries. Good luck!";

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "hard.txt"));
            Random rand = new Random();
            var randomLineNumber = rand.Next(0, lines.Length - 1);
            string line = lines[randomLineNumber]; //randomly gets a word
            solutionHard = line;

            firstChar = Convert.ToString(solutionHard[0]);
            thirdChar = Convert.ToString(solutionHard[2]);
            textBox3.Text = (firstChar + "_" + thirdChar + "_" + "_" + "_" + "_"); //extra letters to make it easier

            textBox6.Text = Convert.ToString(triesHard);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            string answerEasy = textBox3.Text;


            if (answerEasy == solutionEasy) //if the answer is correct
            {
                textBox4.Text = "Correct!";
                MessageBox.Show("Congratulations, you win!");
                this.Close();
            }
            else //if the answer if not correct, lives are taken and "wrong" is displayed.
            {
                int lives;
                Calculations myLives = new Calculations();
                lives = myLives.livesLeft(tries);

                textBox6.Text = Convert.ToString(lives);

                textBox4.Text = "Wrong!";
                tries = tries - 1;

                if (tries == 0) //gameover when lives run out
                {
                    textBox3.Visible = false;
                    MessageBox.Show("Out of lives! Maybe next time.");
                    this.Close();
                }
            }
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            string answerNormal = textBox3.Text;


            if (answerNormal == solutionNormal) //if the answer is correct
            {
                textBox4.Text = "Correct!";
                MessageBox.Show("Congratulations, you win!");
                this.Close();
            }
            else //if the answer if not correct, lives are taken and "wrong" is displayed.
            {
                int lives;
                Calculations myLives = new Calculations();
                lives = myLives.livesLeft(tries);

                textBox6.Text = Convert.ToString(lives);

                textBox4.Text = "Wrong!";
                tries = tries - 1;

                if (tries == 0) //gameover when lives run out
                {
                    textBox3.Visible = false;
                    MessageBox.Show("Out of lives! Maybe next time.");
                    this.Close();
                }

            }
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            string answerHard = textBox3.Text;

            if (answerHard == solutionHard) //if the answer is correct
            {
                textBox4.Text = "Correct!";
                MessageBox.Show("Congratulations, you win!");
                this.Close();
            }
            else //if the answer if not correct, lives are taken and "wrong" is displayed.
            {
                int lives;
                Calculations myLives = new Calculations();
                lives = myLives.livesLeft(triesHard);

                textBox6.Text = Convert.ToString(lives);

                textBox4.Text = "Wrong!";
                triesHard = triesHard - 1;

                if (tries == 0) //gameover when lives run out
                {
                    textBox3.Visible = false;
                    MessageBox.Show("Out of lives! Maybe next time.");
                    this.Close();
                }

            }
        }
    }

    class Calculations //lives calculation to be used for all difficulties
    {
        public int livesLeft(int lives)
        {
            lives = lives - 1;
            return lives;
        }
    }
}
