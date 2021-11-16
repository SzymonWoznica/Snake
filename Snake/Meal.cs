using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Meal
    {
        public Coordinates Position { get; set; }

        public Meal()
        {
            Random random = new Random();
            var x = random.Next(6, 110);
            var y = random.Next(2, 25);
            Position = new Coordinates(x, y);
            Draw();
        }

        virtual protected void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$");
            Console.ResetColor();
        }
    }
}
