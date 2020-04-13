using ConsoleGame.Gui;
using ConsoleGame.Units;
using System;
using System.Collections.Generic;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            GuiController guiController = new GuiController();

            guiController.ShowMenu();

            Console.ReadKey();
        }
}
}
