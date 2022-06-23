using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snek
{
     class EatFood
    {

        private List<Circle> Snake = new List<Circle>();
        private List<Border> Border = new List<Border>();
        private Circle food = new Circle();
        private bool gamePauzed = false;



        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        public EatFood()
        {
            score += 1;
            

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

        }

        public string GetScore()
        {
            return score.ToString();
        }
    }
}
