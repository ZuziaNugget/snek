using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizWinForms
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int wrongAnswer;
        int percentage;
        int totalQuestions;



        public Form1()
        {
            InitializeComponent();

            askQuestion(1);

            totalQuestions = 10;

            wrongAnswer = 1;
        }
        public Form1()
        {
            InitializeComponent();

            askQuestion(1);

            totalQuestions = 10;

            wrongAnswer = 1;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage 

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);


                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + "questions correcelty" + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }


            if (buttonTag == correctAnswer)
            {
                MessageBox.Show("You answerd right");
            }

            else if (wrongAnswer == wrongAnswer)
            {
                MessageBox.Show("You answerd wrong");
            }




            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {



            switch (qnum)
            {
                case 1:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Hoe belangrijk is een schrijfstijl voor je code?";

                    button1.Text = "Belangrijk";
                    button2.Text = "Niet zo belangrijk";
                    button3.Text = "I don't know";
                    button4.Text = "I don't care";

                    correctAnswer = 1;


                    break;
                case 2:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Wat is een goeie manier voor 'print'?";

                    button1.Text = "console.Writeline();";
                    button2.Text = "Console.writeline();";
                    button3.Text = "Console.Writeline();";
                    button4.Text = "Console.WriteLine();";

                    correctAnswer = 4;

                    break;
                case 3:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Wat is de grootste fout bij programeren?";

                    button1.Text = "niet goed afgesloten [;]";
                    button2.Text = "Niet Object georienteerd progameren";
                    button3.Text = "Niet na checken voor type fouten";
                    button4.Text = "De fout is pride";

                    correctAnswer = 3;

                    break;
                case 4:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Wat is de makkelijkste taal om te leren?";

                    button1.Text = "HTML + CSS";
                    button2.Text = "PHP";
                    button3.Text = "Javascript";
                    button4.Text = "C#";

                    correctAnswer = 1;

                    break;
                case 5:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Welk programma voor het programeren is het beste?";

                    button1.Text = "Note++";
                    button2.Text = "Visual Studio Code";
                    button3.Text = "Visual Studio";
                    button4.Text = "Sublime";

                    correctAnswer = 3;

                    break;
                case 6:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Wat is de leukste drama moment op school?";

                    button1.Text = "Niet gamen";
                    button2.Text = "2 mensen gingen in de harde regen naar buiten";
                    button3.Text = "Minecraft server drama (Meerdere keren)";
                    button4.Text = "Challenge 1 drama";

                    correctAnswer = 3;

                    break;
                case 7:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Hoeveel procent van de leerlingen speelt spellen tijdens de les?";

                    button1.Text = "10%";
                    button2.Text = "200%";
                    button3.Text = "60%";
                    button4.Text = "75%";

                    correctAnswer = 3;

                    break;
                case 8:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Wat was de leukste challenge?";

                    button1.Text = "Pokedex";
                    button2.Text = "Max Verstappen";
                    button3.Text = "Certified Secure";
                    button4.Text = "GPS-tocht";

                    correctAnswer = 0;

                    break;
                case 9:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Hoeveel probleem kinderen hebben wij in deze opleiding";

                    button1.Text = "6-10";
                    button2.Text = "4-6";
                    button3.Text = "Probleem Children come from a other World";
                    button4.Text = "yes";

                    correctAnswer = 1;

                    break;
                case 10:
                    Properties.Image = Properties.Resources.Question;



                    lblQuestion.Text = "Hoeveel breakdowns waren er dit schooljaar?";

                    button1.Text = "50-75";
                    button2.Text = "200+";
                    button3.Text = "Unknown";
                    button4.Text = "Infinite";

                    correctAnswer = 0;

                    break;













            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private PictureBox Properties;

        private void InitializeComponent()
        {
            this.Properties = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Properties
            // 
            this.Properties.AccessibleName = "PictureBox1";
            this.Properties.Image = global::Quiz1.Properties.Resources.Question_Mark_PNG_Free_Download;
            this.Properties.Location = new System.Drawing.Point(163, 12);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(688, 243);
            this.Properties.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Properties.TabIndex = 0;
            this.Properties.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(163, 298);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(50, 20);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(269, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 639);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.Properties);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblQuestion;
        private Button button1;
        private Button button2;
        private Button button3;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private Button button4;
    }
}