using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class GameOver
    {
        public GameOver(Player player, Snake snake)
        {
            Console.Clear();

            HUD hud = new HUD();
            Console.WriteLine("\n\n");
            hud.ShowLogo();
            Console.SetCursorPosition(41, 16);
            Console.WriteLine("Dear " + player.PlayerName + ", your score is: " + snake.Score);
            Console.ReadKey();
        }
    }
}
