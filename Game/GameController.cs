using ConsoleGame.Gui;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Units
{
    class GameController
    {

        private GameScreen myGame;


        public void StartGame()
        {
            InitGame();

            StartGameLoop();

        }




        private void InitGame()
        {
            myGame = new GameScreen(width: 30, height: 20);
            myGame.SetHero(new Hero(5, 5, "HERO"));

            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }
        }

        private void StartGameLoop()
        {
            myGame.Render();
            bool needToRender = true;
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            GuiController guiController = new GuiController();
                            guiController.ShowMenu();
                            myGame.Render();
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            myGame.Render();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            myGame.Render();
                            break;
                    }
                }



                // System.Threading.Thread.Sleep(250);
            } while (needToRender);
        }
    }
}
