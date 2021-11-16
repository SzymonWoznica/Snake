using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Snake
{
    class Rectangle
    {
        public Coordinates LeftUpCorner { get; set; }
        public Coordinates RighttUpCorner { get; set; }
        public Coordinates LeftDownCorner { get; set; }
        public Coordinates RightDownCorner { get; set; }
        public List<Coordinates> BorderPointsList = new List<Coordinates>();


        public char Symbol { get; set; }

        public Rectangle(Coordinates leftUpCorner, Coordinates rightDownCorner, char symbol, ConsoleColor color)
        {
            LeftUpCorner = leftUpCorner;
            RighttUpCorner = new Coordinates(rightDownCorner.X, leftUpCorner.Y);
            LeftDownCorner = new Coordinates(leftUpCorner.X, rightDownCorner.Y);
            RightDownCorner = rightDownCorner;
            Symbol = symbol;

            Console.ForegroundColor = color;

            DrawWall(LeftUpCorner, RighttUpCorner);
            DrawWall(RighttUpCorner, RightDownCorner);
            DrawWall(LeftDownCorner, RightDownCorner); 
            DrawWall(LeftUpCorner, LeftDownCorner); 
        }

        public void DrawWall(Coordinates startPosition, Coordinates finishPosition)
        {
            if(startPosition.X == finishPosition.X)
            {
                for(int i = startPosition.Y; i <= finishPosition.Y; i++)
                {
                    Console.SetCursorPosition(startPosition.X, i);
                    Console.WriteLine(Symbol);
                    BorderPointsList.Add(new Coordinates(startPosition.X, i));
                }
            }
            else if(startPosition.Y == finishPosition.Y)
            {
                for (int i = startPosition.X; i <= finishPosition.X; i++)
                {
                    Console.SetCursorPosition(i, startPosition.Y);
                    Console.WriteLine(Symbol);
                    BorderPointsList.Add(new Coordinates(i, startPosition.Y));

                }
            }
        }


    }
}
