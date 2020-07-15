using System;
using System.CodeDom.Compiler;
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

        //global constants
        const int MAX_ADDITION_VALUE = 50;
        const int MAX_SUBTRACTION_VALUE = 100;
        const int MAX_MULTIPLICATION_VALUE = 10;
        const int MAX_QUOTIENT_VALUE = 10;
        const int INITIAL_TIMER_VALUE = 30;

        //Addition Variables
        int addend1;
        int addend2;
        //Subtraction Variables
        int leftSubSide;
        int rightSubSide;
        //Multiplication Variables
        int leftFactor;
        int rightFactor;
        //Division Variables
        int leftDiv;
        int rightDiv;

        // Timer
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }
        //Form Methods
        public void StartTheQuiz() 
        {
            //Sets up a value for the addition arguments, changes the labels, and resets the sum to zero.
            addend1 = randomizer.Next(MAX_ADDITION_VALUE+1);
            addend2 = randomizer.Next(MAX_ADDITION_VALUE + 1);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sumNumericUpDown.Value = 0;
            //Subtraction Value Initialization
            leftSubSide = randomizer.Next(1, 1 + MAX_SUBTRACTION_VALUE);
            rightSubSide = randomizer.Next(1, leftSubSide);
            minusLeftLabel.Text = leftSubSide.ToString();
            minusRightLabel.Text = rightSubSide.ToString();
            differenceNumericUpDown.Value = 0;
            //Multiplication Value Initialization
            leftFactor = randomizer.Next(1, MAX_MULTIPLICATION_VALUE+1);
            rightFactor = randomizer.Next(1, MAX_MULTIPLICATION_VALUE+1);
            timesLeftLabel.Text = leftFactor.ToString();
            timesRightLabel.Text = rightFactor.ToString();
            productNumericUpDown.Value = 0;
            ////Division Value Initialization - this decides on a random quotient, then generates the
            //dividend and divisor required to implement it. 
            int tempQuotient = randomizer.Next(2, MAX_QUOTIENT_VALUE + 1);
            rightDiv = randomizer.Next(2, MAX_QUOTIENT_VALUE + 1);
            leftDiv = rightDiv * tempQuotient;
            dividedLeftLabel.Text = leftDiv.ToString();
            dividedRightLabel.Text = rightDiv.ToString();
            quotientNumericUpDown.Value = 0;

            //Setting the number entry controls to their defaults.
            //Addition
            sumNumericUpDown.BackColor = Color.White;
            sumNumericUpDown.Enabled = true;
            //Subtraction
            differenceNumericUpDown.BackColor = Color.White;
            differenceNumericUpDown.Enabled = true;
            //Multiplication
            productNumericUpDown.BackColor = Color.White;
            productNumericUpDown.Enabled = true;
            //Division
            quotientNumericUpDown.BackColor = Color.White;
            quotientNumericUpDown.Enabled = true;

            //Initialize timer
            timeLeft = INITIAL_TIMER_VALUE;
            timeLabel.Text = INITIAL_TIMER_VALUE + " seconds";
            timer1.Start();

        }
        //Answer checking methods
        public bool checkAnswerSum() 
        {
            if (sumNumericUpDown.Value == (addend2 + addend1)) 
                {
                return true;
                }
            else { return false; }
        }
        public bool checkAnswerDifference()
        {
            if ( differenceNumericUpDown.Value == ( leftSubSide- rightSubSide))
            {
                return true;
            }
            else { return false; }
        }
        public bool checkAnswerProduct()
        {
            if (productNumericUpDown.Value == (leftFactor * rightFactor))
            {
                return true;
            }
            else { return false; }
        }
        public bool checkAnswerQuotient()
        {
            if (quotientNumericUpDown.Value == (leftDiv / rightDiv))
            {
                return true;
            }
            else { return false; }
        }
        private void plusSignLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void quizStartBtn_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
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
                //Per question checking
                if (checkAnswerSum()) 
                { 
                    sumNumericUpDown.BackColor = Color.LawnGreen;
                    sumNumericUpDown.Enabled = false;
                }
                if (checkAnswerDifference())
                {
                    differenceNumericUpDown.BackColor = Color.LawnGreen;
                    differenceNumericUpDown.Enabled = false;
                }
                if (checkAnswerProduct())
                {
                    productNumericUpDown.BackColor = Color.LawnGreen;
                    productNumericUpDown.Enabled = false;
                }
                if (checkAnswerQuotient())
                {
                    quotientNumericUpDown.BackColor = Color.LawnGreen;
                    quotientNumericUpDown.Enabled = false;
                }
                //Overall answer checking
                if (checkAnswerSum() & checkAnswerDifference() & checkAnswerProduct() & checkAnswerQuotient()) 
                {
                    timer1.Stop();
                    messageBox.Text = "Congratulations, you answered all the questions correctly!";
                    quizStartBtn.Enabled = true;
                }

            }
            else 
            //The user ran out of time - display a message, fill in answers, reset the start button
            {
                timeLabel.Text = "Time's Up!";
                sumNumericUpDown.Value = addend1 + addend2;
                quizStartBtn.Enabled = true;
            }
        }

        private void sumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
           
        }

        //Generic event handler for entering in an answer to a numeric updown box. It selects
        //the text contents of the answerbox, making it so the user doesn't need to highlight it. 
        private void answer_entry(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            //Select the whole contents to allow for them to be changed. 
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        //Mouse Click Event Handlers
        private void sumNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            answer_entry(sender, e);
        }

        private void quotientNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            answer_entry(sender, e);
        }

        private void productNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            answer_entry(sender, e);
        }
    }
}
