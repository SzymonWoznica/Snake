using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Properties
    {
        protected double AppVersion { get; } = 1.0;
        protected string AppAuthor { get; } = "Szymon Woźnica";
        protected string AppName { get; } = "Snake";

        public Properties()
        {
            Console.Title = this.AppName;
            Console.SetWindowSize(117, 35);
            Console.CursorVisible = false;
            Console.SetBufferSize(117, 35);
        
            Console.TreatControlCAsInput = true;
        }

    }
}
