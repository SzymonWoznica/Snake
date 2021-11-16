using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class MainMenu
    {
        public MenuPosition menuPostion = MenuPosition.Game;
        public bool exit = false;
        HUD hud = new HUD();

        public MainMenu()
        {
            Draw();
        }
        public void Draw()
        {
            while (!exit)
            {
                Console.SetCursorPosition(0, 5);
                hud.ShowLogo();

                Console.SetCursorPosition(46, 34);
                hud.ShowFooter();

                ShowMenu();

                Console.Clear();
            }

        }

        private void ShowMenu()
        {
            switch (menuPostion)
            {
                case MenuPosition.Game:
                    DrawPlayGameMenuPosition();
                    break;

                case MenuPosition.Exit:
                    DrawExitMenuPosition();
                    break;
            }
            GetMenuPosition();

        }
        private void GetMenuPosition()
        {

            ConsoleKeyInfo inputKey = Console.ReadKey(true);

            int numericMenuPosition = (int)menuPostion;
            var maxEnumValue = Enum.GetNames(typeof(MenuPosition)).Length - 3;

            switch (inputKey.Key)
            {
                case ConsoleKey.DownArrow:
                    menuPostion = (numericMenuPosition < maxEnumValue) ? (MenuPosition)numericMenuPosition + 1 : (MenuPosition)numericMenuPosition;
                    break;

                case ConsoleKey.UpArrow:
                    menuPostion = (numericMenuPosition > 0) ? (MenuPosition)numericMenuPosition - 1 : (MenuPosition)numericMenuPosition;
                    break;

                case ConsoleKey.Enter:
                    exit = true;
                    break;
            }
        }
        private void DrawPlayGameMenuPosition()
        {
            Console.SetCursorPosition(50, 20);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>  PLAY  <<<");
            Console.ResetColor();

            Console.SetCursorPosition(55, 25);
            Console.WriteLine("EXIT");
        }

        private void DrawExitMenuPosition()
        {
            Console.SetCursorPosition(55, 20);
            Console.WriteLine("PLAY");

            Console.SetCursorPosition(50, 25);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" >>> EXIT <<< ");
            Console.ResetColor();
        }
        public int ReturnPositionMenu()
        {
            return (int)menuPostion;
        }

    }

}
