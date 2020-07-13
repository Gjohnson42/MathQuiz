namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusSignLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.equalsLabel = new System.Windows.Forms.Label();
            this.sumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.differenceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.productNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.quotientNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.quizStartBtn = new System.Windows.Forms.Button();
            this.userNameTextBox1 = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotientNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(18, 19);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(129, 33);
            this.timeLeftLabel.TabIndex = 0;
            this.timeLeftLabel.Text = "Time Left";
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(166, 19);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(12, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSignLabel
            // 
            this.plusSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSignLabel.Location = new System.Drawing.Point(78, 75);
            this.plusSignLabel.Name = "plusSignLabel";
            this.plusSignLabel.Size = new System.Drawing.Size(60, 50);
            this.plusSignLabel.TabIndex = 3;
            this.plusSignLabel.Text = "+";
            this.plusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusSignLabel.Click += new System.EventHandler(this.plusSignLabel_Click);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(144, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsLabel
            // 
            this.equalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel.Location = new System.Drawing.Point(194, 75);
            this.equalsLabel.Name = "equalsLabel";
            this.equalsLabel.Size = new System.Drawing.Size(60, 50);
            this.equalsLabel.TabIndex = 30;
            this.equalsLabel.Text = "=";
            this.equalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumNumericUpDown
            // 
            this.sumNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumNumericUpDown.Location = new System.Drawing.Point(266, 80);
            this.sumNumericUpDown.Name = "sumNumericUpDown";
            this.sumNumericUpDown.Size = new System.Drawing.Size(100, 41);
            this.sumNumericUpDown.TabIndex = 2;
            // 
            // differenceNumericUpDown
            // 
            this.differenceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceNumericUpDown.Location = new System.Drawing.Point(266, 130);
            this.differenceNumericUpDown.Name = "differenceNumericUpDown";
            this.differenceNumericUpDown.Size = new System.Drawing.Size(100, 41);
            this.differenceNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(144, 125);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 9;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(12, 125);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productNumericUpDown
            // 
            this.productNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNumericUpDown.Location = new System.Drawing.Point(266, 180);
            this.productNumericUpDown.Name = "productNumericUpDown";
            this.productNumericUpDown.Size = new System.Drawing.Size(100, 41);
            this.productNumericUpDown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 40;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(144, 175);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 14;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 13;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(12, 175);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotientNumericUpDown
            // 
            this.quotientNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotientNumericUpDown.Location = new System.Drawing.Point(266, 227);
            this.quotientNumericUpDown.Name = "quotientNumericUpDown";
            this.quotientNumericUpDown.Size = new System.Drawing.Size(100, 41);
            this.quotientNumericUpDown.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 47);
            this.label4.TabIndex = 20;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(144, 225);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 47);
            this.dividedRightLabel.TabIndex = 19;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 47);
            this.label7.TabIndex = 18;
            this.label7.Text = "÷";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(12, 225);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 47);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quizStartBtn
            // 
            this.quizStartBtn.AutoSize = true;
            this.quizStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizStartBtn.Location = new System.Drawing.Point(102, 398);
            this.quizStartBtn.Name = "quizStartBtn";
            this.quizStartBtn.Size = new System.Drawing.Size(176, 39);
            this.quizStartBtn.TabIndex = 1;
            this.quizStartBtn.Text = "Start the Quiz";
            this.quizStartBtn.UseVisualStyleBackColor = true;
            this.quizStartBtn.Click += new System.EventHandler(this.quizStartBtn_Click);
            // 
            // userNameTextBox1
            // 
            this.userNameTextBox1.Location = new System.Drawing.Point(18, 326);
            this.userNameTextBox1.Name = "userNameTextBox1";
            this.userNameTextBox1.Size = new System.Drawing.Size(120, 22);
            this.userNameTextBox1.TabIndex = 41;
            this.userNameTextBox1.Text = "Enter User Name";
            this.userNameTextBox1.TextChanged += new System.EventHandler(this.userNameTextBox1_TextChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(200, 326);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 17);
            this.userNameLabel.TabIndex = 42;
            this.userNameLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 449);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextBox1);
            this.Controls.Add(this.quizStartBtn);
            this.Controls.Add(this.quotientNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.productNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.differenceNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sumNumericUpDown);
            this.Controls.Add(this.equalsLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusSignLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotientNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusSignLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label equalsLabel;
        private System.Windows.Forms.NumericUpDown sumNumericUpDown;
        private System.Windows.Forms.NumericUpDown differenceNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown productNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown quotientNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Button quizStartBtn;
        private System.Windows.Forms.TextBox userNameTextBox1;
        private System.Windows.Forms.Label userNameLabel;
    }
}

