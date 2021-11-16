using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Snake
{
    class Snake : ISnake
    {
        public Coordinates HeadPosition { get; set; } = new Coordinates(10, 10);
        private int Lenght { get; set; } = 7;
        List<Coordinates> Tail { get; set; } = new List<Coordinates>();
        List<Coordinates> BorderPointsList { get; set; } = new List<Coordinates>();
        public int Score { get; set; } = 0;
        public Dircetion DircetionSnake = Dircetion.Right;
        public bool GameOver { get; set; } = false;

        public void AddScore()
        {
            Score++;
        }

        public void EatMeal()
        {
            Lenght++;
            AddScore();
        }

        public void Move()
        {
            switch (DircetionSnake)
            {
                case Dircetion.Down:
                    HeadPosition.Y++;
                    break;

                case Dircetion.Up:
                    HeadPosition.Y--;
                    break;

                case Dircetion.Left:
                    HeadPosition.X--;
                    break;

                case Dircetion.Right:
                    HeadPosition.X++;
                    break;

            }
            try
            {
                // Draw the new head position 
                Console.SetCursorPosition(HeadPosition.X, HeadPosition.Y);
                Console.WriteLine("@");

                Tail.Add(new Coordinates(HeadPosition.X, HeadPosition.Y));

                // Clear last point of tail
                if(Tail.Count > this.Lenght)
                {
                    var endTail = Tail.First();
                    Console.SetCursorPosition(endTail.X, endTail.Y);
                    Console.WriteLine(" ");
                    Tail.Remove(endTail);
                }

            }
            catch(ArgumentOutOfRangeException)
            {
                GameOver = true;
            }

        }
        
        private void CheckTailCollision()
        {
            if ((Tail.Where(c => c.X == HeadPosition.X && c.Y == HeadPosition.Y).ToList().Count > 1))
            {
                GameOver = true;
            }
        }

        private void CheckBorderCollision()
        {
            if((BorderPointsList.Where(c=>c.X == HeadPosition.X && c.Y == HeadPosition.Y).ToList().Count > 0))
            {
                GameOver = true;
            }
                      
        }

        public void GetBorderList(List<Coordinates> list)
        {
            BorderPointsList = list;
        }
        public bool CheckGameOver()
        {
            CheckBorderCollision();
            CheckTailCollision();
            return GameOver == true;
        }
        public void TurnLeft()
        {
            if(DircetionSnake != Dircetion.Right)
            {
                DircetionSnake = Dircetion.Left;
            }
        }

        public void TurnRight()
        {
            if (DircetionSnake != Dircetion.Left)
            {
                DircetionSnake = Dircetion.Right;
            }
        }

        public void TurnUp()
        {
            if (DircetionSnake != Dircetion.Down)
            {
                DircetionSnake = Dircetion.Up;
            }
        }

        public void TurnDown()
        {
            if (DircetionSnake != Dircetion.Up)
            {
                DircetionSnake = Dircetion.Down;
            }
        }
    }
    public enum Dircetion { Up, Down, Left, Right };
}
