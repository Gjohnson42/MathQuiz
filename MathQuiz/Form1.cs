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
        int addend1;
        int addend2;
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
    }
}
