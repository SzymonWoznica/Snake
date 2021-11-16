using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Game
    {
        public string PlayerName { get; set; }
        public int TotalScore { get; set; }
        public Game()
        {
            Player player = new Player();
            HUD hud = new HUD();
            Meal meal = new Meal();
            Snake snake = new Snake();
            DateTime lastTime = DateTime.Now;

            bool gameOver = false;
            double frame = 1000 / 15;

            hud.DrawGameHUD(player);

            snake.GetBorderList(hud.BorderPointsList);

            while (!gameOver)
            {
                // Control the snake
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressKey = Console.ReadKey(true);

                    switch(pressKey.Key)
                    {
                        case ConsoleKey.UpArrow:
                            snake.TurnUp();
                            break;

                        case ConsoleKey.RightArrow:
                            snake.TurnRight();
                            break;

                        case ConsoleKey.LeftArrow:
                            snake.TurnLeft();
                            break;

                        case ConsoleKey.DownArrow:
                            snake.TurnDown();
                            break;
                    }
                }

                // Move snake
                if((DateTime.Now - lastTime).Milliseconds >= frame)
                {
                    lastTime = DateTime.Now;
                    snake.Move();
                }

                // Eat a meal
                if(snake.HeadPosition.X == meal.Position.X && snake.HeadPosition.Y == meal.Position.Y)
                {
                    snake.EatMeal();
                    meal = new Meal();
                    hud.DrawScore(snake.Score);
                    frame /= 1.1;
                }

                gameOver = snake.CheckGameOver();
            }
            GameOver overScreen = new GameOver(player, snake);

            Console.Clear();
        }


    }
}
