using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Drying_Paint
{
    class Game
    {
        public void Start()
        {
            Console.Title = "Paint Drying - The Game";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = (@"
______     _       _    ______            _             
| ___ \   (_)     | |   |  _  \          (_)            
| |_/ /_ _ _ _ __ | |_  | | | |_ __ _   _ _ _ __   __ _ 
|  __/ _` | | '_ \| __| | | | | '__| | | | | '_ \ / _` |
| | | (_| | | | | | |_  | |/ /| |  | |_| | | | | | (_| |
\_|  \__,_|_|_| |_|\__| |___/ |_|   \__, |_|_| |_|\__, |
                                     __/ |         __/ |
                                    |___/         |___/ 

Welcome to the Paint Drying game. What would you like to do?
Use Arrow keys to navigate menu.
Press ENTER to select an option.");

            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunPlay();
                    break;
                case 1:
                    ShowAbout();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void RunPlay()
        {
            string prompt = "What color paint would you like to watch dry?";
            string[] options = { "Blue", "Red", "Green", "Yellow" };
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            Console.BackgroundColor = ConsoleColor.White;
            switch (selectedIndex)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nBlue Paint drying on the console");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nRed Paint drying on the console");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nGreen Paint drying on the console");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYellow Paint drying on the console");
                    break;
            }
            Console.ResetColor();
            Console.WriteLine("The paint will continue drying, press any key to return to the main menu");
            ReadKey(true);
            RunMainMenu();
        }

        private void ShowAbout()
        {
            Console.Clear();
            Console.WriteLine("Tutorial by Mike H.");
            Console.WriteLine("ASCII art from: https://patorjk.com/software/taag/ ");
            Console.WriteLine("Press any key to return to menu");
            ReadKey(true);
            RunMainMenu();
        }

        private void ExitGame()
        {
            Console.Clear();
        }


    }
}
