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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int tries = 4, triesHard = 3;
        string solutionEasy, solutionNormal, solutionHard;

        class scrambleEasy //easy scrambling
        {
            public string scramEasy(string scramble) //scrambling sticks to a fixed pattern
            {
                string newScramble;

                string firstChar = Convert.ToString(scramble[0]);
                string secondChar = Convert.ToString(scramble[1]);
                string thirdChar = Convert.ToString(scramble[2]);
                string fourthChar = Convert.ToString(scramble[3]);
                string fifthChar = Convert.ToString(scramble[4]);

                newScramble = (secondChar + firstChar + thirdChar + fifthChar + fourthChar);
                scramble = newScramble;

                return scramble;
            }
        }

        class scrambleNormal //Scrambling for the normal difficulty
        {
            string vowel = "";
            string conson = "";

            public string scramNormal(string scramble) //scrambling is dependant on the type of char.
            {
                foreach (char o in scramble)
                {
                    if ((o == 'a') || (o == 'e') || (o == 'i') || (o == 'o') || (o == 'u') || (o == 'A') || (o == 'E') || (o == 'I') || (o == 'O') || (o == 'U'))
                        vowel = vowel + o;
                }

                foreach (char cons in scramble)
                    if ((cons == 'B') || (cons == 'C') || (cons == 'D') || (cons == 'F') || (cons == 'G') || (cons == 'H') || (cons == 'J') || (cons == 'K') || (cons == 'L') || (cons == 'M') || (cons == 'N') || (cons == 'P') || (cons == 'Q') || (cons == 'R') || (cons == 'S') || (cons == 'T') || (cons == 'V') || (cons == 'W') || (cons == 'X') || (cons == 'Y') || (cons == 'Z') || (cons == 'b') || (cons == 'c') || (cons == 'd') || (cons == 'f') || (cons == 'g') || (cons == 'h') || (cons == 'j') || (cons == 'k') || (cons == 'l') || (cons == 'm') || (cons == 'n') || (cons == 'p') || (cons == 'q') || (cons == 'r') || (cons == 's') || (cons == 't') || (cons == 'v') || (cons == 'w') || (cons == 'x') || (cons == 'y') || (cons == 'z'))
                    {
                        conson = conson + cons;
                    }
                scramble = conson + vowel;
                return scramble;
            }
        }

        class scrambleHard //scramble the word for the hard difficlty
        {
            string even = "";
            string odd = "";
            int counter = 0;

            public string scramHard(string scramble)
            {
                foreach (char e in scramble)
                {
                    counter++;

                    if (counter % 2 == 0) //random scrambling, depening on the placement of the character
                    {
                        even = even + e;
                    }
                    else
                    {
                        odd = odd + e;
                    }
                }
                scramble = odd + even;
                return scramble;
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


        private void Easybutton_Click(object sender, EventArgs e)
        {
            Easybutton.Visible = false;
            buttonNormal.Visible = false;
            buttonHard.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            explaination.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            Easy.Visible = true;

            explaination.Text = "The word is five letters long. Unscramble the word, you have four tries. Good luck!";

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "easy.txt")); 
            Random rand = new Random();
            var randomLineNumber = rand.Next(0, lines.Length - 1);
            string line = lines[randomLineNumber];
            solutionEasy = line;

            string newWord;
            scrambleEasy mixed = new scrambleEasy();
            newWord = mixed.scramEasy(solutionEasy);

            textBox2.Text = newWord;
            textBox6.Text = Convert.ToString(tries);
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            Easybutton.Visible = false;
            buttonNormal.Visible = false;
            buttonHard.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            explaination.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            Normal.Visible = true;

            explaination.Text = "The word is six letters long. Unscramble the word, you have four tries. Good luck!";

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "normal.txt"));
            Random rand = new Random();
            var randomLineNumber = rand.Next(0, lines.Length - 1);
            string line = lines[randomLineNumber];
            solutionNormal = line;

            string newWord;
            scrambleNormal mixed = new scrambleNormal();
            newWord = mixed.scramNormal(solutionNormal);

            textBox2.Text = newWord;
            textBox6.Text = Convert.ToString(tries);

        }

        private void Hard_Click(object sender, EventArgs e)
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

                if (triesHard == 0) //gameover when lives run out
                {
                    textBox3.Visible = false;
                    MessageBox.Show("Out of lives! Maybe next time.");
                    this.Close();
                }
            }
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            Easybutton.Visible = false;
            buttonNormal.Visible = false;
            buttonHard.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            explaination.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            Hard.Visible = true;

            explaination.Text = "The word is seven letters long. Unscramble the word, you have three tries. Good luck!";

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "hard.txt"));
            Random rand = new Random();
            var randomLineNumber = rand.Next(0, lines.Length - 1);
            string line = lines[randomLineNumber];
            solutionHard = line;

            string newWord;
            scrambleHard mixed = new scrambleHard();
            newWord = mixed.scramHard(solutionHard);

            textBox2.Text = newWord;
            textBox6.Text = Convert.ToString(triesHard);
        }

        private void Normal_Click(object sender, EventArgs e)
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

        private void Easy_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }          
    }
}
