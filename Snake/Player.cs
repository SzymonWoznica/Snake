using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Player
    {
        public string PlayerName;

        public Player()
        {
            Console.Clear();

            HUD hud = new HUD();
            
            Console.SetCursorPosition(0, 4);
            hud.ShowLogo();

            Console.SetCursorPosition(48, 20);
            Console.Write("Enter player name: ");
 
            PlayerName = Console.ReadLine();

            Console.Clear();

        }
    }
}
