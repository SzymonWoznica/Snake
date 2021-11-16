using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Init
    {
        bool exit = false;
        MenuPosition screen = MenuPosition.MainMenu;

        public Init()
        {
            Properties properties = new Properties();
            ChooseScreen(screen);
        }

        protected void ChooseScreen(MenuPosition screen)
        {
            while (!exit)
            {
                switch (screen)
                {
                    case MenuPosition.MainMenu:
                        MainMenu mainMenu = new MainMenu();
                        screen = (MenuPosition)mainMenu.ReturnPositionMenu();
                        break;

                    case MenuPosition.Game:
                        Game game = new Game();
                        screen = MenuPosition.MainMenu;
                        break;

                    case MenuPosition.Exit:
                        exit = true;
                        break;
                }
            }
        }

    }
}
