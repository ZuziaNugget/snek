using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging; // for JPG compressor

namespace snek
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private List<Border> Border = new List<Border>();
        private Circle food = new Circle();
        private Label gameOverLabel = new Label();
        private bool gamePauzed = false;



        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;


        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            gameOverLabel.Hide();
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "I scored " + score + " and my Highscore is " + highScore + " in the snake game";
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor = Color.SeaGreen;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 100;
            caption.TextAlign = ContentAlignment.BottomCenter;
            picCanvas.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game SnapShot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0,0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }
            else
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }




        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            if (gamePauzed == false)
            {
                // setting the directions

                if (goLeft)
                {
                    Settings.directions = "left";
                }
                if (goRight)
                {
                    Settings.directions = "right";
                }
                if (goDown)
                {
                    Settings.directions = "down";
                }
                if (goUp)
                {
                    Settings.directions = "up";
                }
                // end of directions

                //Borders

                /*           foreach (Control x in this.Controls)
                           {
                               if (x is PictureBox && (string)x.Tag == "Object")
                               {
                                  if (Snake.First().X == 599)
                                   {
                                       GameOver();
                                   }
                                   if (Snake.First().Y == 691)
                                   {
                                       GameOver();
                                   } 
                                   if (Snake.First().X == 0)
                                   {
                                       GameOver();
                                   }
                                   if (Snake.First().Y == 0)
                                   {
                                       GameOver();
                                   }

                               }
                           }*/

                //EndBorders

                for (int i = Snake.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {

                        switch (Settings.directions)
                        {
                            case "left":
                                Snake[i].X--;
                                break;
                            case "right":
                                Snake[i].X++;
                                break;
                            case "down":
                                Snake[i].Y++;
                                break;
                            case "up":
                                Snake[i].Y--;
                                break;
                        }

                        if (Snake[i].X < 0)
                        {
                            Snake[i].X = maxWidth;
                        }
                        if (Snake[i].X > maxWidth)
                        {
                            Snake[i].X = 0;
                        }
                        if (Snake[i].Y < 0)
                        {
                            Snake[i].Y = maxHeight;
                        }
                        if (Snake[i].Y > maxHeight)
                        {
                            Snake[i].Y = 0;
                        }


                        if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                        {
                            gamePauzed = true;
                            Form2 form2 = new Form2();
                            form2.gameForm = this;
                            

                            if (form2.ShowDialog() == DialogResult.OK)

                            {
                                gamePauzed = false;
                            }
                            


                        }

                        for (int j = 1; j < Snake.Count; j++)
                        {

                            if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                            {
                                GameOver();
                            }

                        }

                        for (int t = 1; t < Border.Count; t++)
                        {
                            if (Snake[i].X == Border[t].X)
                            {
                                GameOver();
                            }
                        }

                        for (int l = 1; l < Border.Count; l++)
                        {
                            if (Snake[i].Y == Border[l].Y)
                            {
                                GameOver();
                            }
                        }
                    }
                    else
                    {
                        Snake[i].X = Snake[i - 1].X;
                        Snake[i].Y = Snake[i - 1].Y;
                    }
                }


                picCanvas.Invalidate(); 
            }


        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if(i == 0)
                {
                    snakeColour = Brushes.SeaGreen;
                }
                else
                {
                    snakeColour = Brushes.DarkSeaGreen;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }


            canvas.FillEllipse(Brushes.DarkOrange, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            gamePauzed = !gamePauzed;
        }

        private void ShouldPauze()
        {

        }

        private void RestartGame()
        {

            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();

            StartButton.Enabled = false;
            SnapButton.Enabled = false;
            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head = new Circle { X = 18, Y = 21};
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            for (int t = 0; t < 10; t++)
            {
                Border border = new Border { X = 0};
                Border.Add(border);
            }

            for (int t = 0; t < 10; t++)
            {
                Border border = new Border { X = 36};
                Border.Add(border);
            }

            for (int l = 0; l < 10; l++)
            {
                Border border = new Border { Y = 0 };
                Border.Add(border);
            }

            for (int l = 0; l < 10; l++)
            {
                Border border = new Border { Y = 42 };
                Border.Add(border);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();


        }

        public void EatFood()
        {
            score += 1;

            txtScore.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

        }

        public void PoopFood()
        {
            score -= 1;

            txtScore.Text = "Score: " + score;

            Snake.RemoveAt(Snake.Count - 1);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

        }

        private void GameOver()
        {
            gameTimer.Stop();

            gameOverLabel.Text = "Game Over";
            gameOverLabel.Font = new Font("Ariel", 36, FontStyle.Bold);
            gameOverLabel.ForeColor = Color.SeaGreen;
            picCanvas.Controls.Add(gameOverLabel);
            gameOverLabel.TextAlign = ContentAlignment.TopCenter;
            gameOverLabel.AutoSize = false;
            gameOverLabel.Width = picCanvas.Width;
            gameOverLabel.Height = 70;
            gameOverLabel.Show();

            StartButton.Enabled = true;
            SnapButton.Enabled = true;

            if (score > highScore)
            {
                highScore = score;

                txtHighScore.Text = "High Score: " + Environment.NewLine + highScore;
                txtHighScore.ForeColor = Color.Maroon;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }


    }
}
