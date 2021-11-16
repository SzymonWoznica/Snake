using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HUD
    {
        public List<Coordinates> BorderPointsList = new List<Coordinates>();



        public void DrawGameHUD(Player player)
        {
            Rectangle BorderWindow = new Rectangle(new Coordinates(5, 1), new Coordinates(111, 25), '#', ConsoleColor.Red);
            Rectangle ScoreBorder = new Rectangle(new Coordinates(5, 26), new Coordinates(30, 33), '#', ConsoleColor.Red);
            Rectangle SpecialBorder = new Rectangle(new Coordinates(30, 26), new Coordinates(80, 33), '#', ConsoleColor.Red);
            Rectangle PlayerNameBorder = new Rectangle(new Coordinates(80, 26), new Coordinates(111, 33), '#', ConsoleColor.Red);
            
            Console.SetCursorPosition(13, 28);
            Console.WriteLine("Score:");
            Console.SetCursorPosition(49, 28);
            Console.WriteLine("Goood Luck!");
            Console.SetCursorPosition(88, 28);
            Console.WriteLine("Player name:");
            Console.SetCursorPosition(88, 30);
            Console.WriteLine(player.PlayerName);

            BorderPointsList = BorderWindow.BorderPointsList;

            DrawScore(0);
        }

        public void DrawScore(int score)
        {
            Console.SetCursorPosition(15, 30);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(score);
            Console.ResetColor();

        }

        public void ShowLogo()
        {

            Console.Write("\t\t\t\t ________  ________   ________  ___  __    _______      \n" +
                            "\t\t\t\t|\\   ____\\|\\   ___  \\|\\   __  \\|\\  \\|\\  \\ |\\  ___ \\     \n" +
                            "\t\t\t\t\\ \\  \\___|\\ \\  \\\\ \\  \\ \\  \\|\\  \\ \\  \\/  /|\\ \\   __/|    \n" +
                            "\t\t\t\t \\ \\_____  \\ \\  \\\\ \\  \\ \\   __  \\ \\   ___  \\ \\  \\_|/__  \n" +
                            "\t\t\t\t  \\|____|\\  \\ \\  \\\\ \\  \\ \\  \\ \\  \\ \\  \\\\ \\  \\ \\  \\_|\\ \\ \n" +
                            "\t\t\t\t    ____\\_\\  \\ \\__\\\\ \\__\\ \\__\\ \\__\\ \\__\\\\ \\__\\ \\_______\\ \n" +
                            "\t\t\t\t   |\\_________\\|__| \\|__|\\|__|\\|__|\\|__| \\|__|\\|_______|\n" +
                            "\t\t\t\t   \\|_________|                                         \n");
        }

        public void ShowFooter()
        {
            Console.WriteLine("Code by Szymon Woźnica");
        }



    }
}
