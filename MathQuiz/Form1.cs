using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        //Variable instantiation Section
        //Random class instantiation used for developing RNG Values
        Random randomizer = new Random();

        //Addition Variables
        const int MAX_ADDITION_VALUE = 50;
        const int INITIAL_TIMER_VALUE = 30;
        int addend1;
        int addend2;

        // Timer
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }
        //Form Methods
        public void startTheQuiz() 
        {
            //Sets up a value for the addition arguments, changes the labels, and resets the sum to zero.
            addend1 = randomizer.Next(MAX_ADDITION_VALUE+1);
            addend2 = randomizer.Next(MAX_ADDITION_VALUE + 1);

            //Changing labels
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sumNumericUpDown.Value = 0;

            //Initialize timer
            timeLeft = INITIAL_TIMER_VALUE;
            timeLabel.Text = INITIAL_TIMER_VALUE + " seconds";
            timer1.Start();

        }

        private void plusSignLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void quizStartBtn_Click(object sender, EventArgs e)
        {
            startTheQuiz();
            quizStartBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void userNameTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            User newUser = new User(userNameTextBox1.Text);
            userNameLabel.Text = newUser.makeGreeting();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                //Update time and display it
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else 
            //The user ran out of time - display a message, fill in answers, reset the start button
            {
                timeLabel.Text = "Time's Up!";
                sumNumericUpDown.Value = addend1 + addend2;
                quizStartBtn.Enabled = true;
            }
        }
    }
}
