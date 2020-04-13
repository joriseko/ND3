using ConsoleGame.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Gui
{
    class GuiController
    {


        private GameWindow gameWindow;
        private CreditWindow creditWindow;
        
        public GuiController()
        {
            gameWindow = new GameWindow();
        }


        public void ShowMenu()
        {
            Console.CursorVisible = false;
            gameWindow.Render();
         // creditWindow.Render();
            StartMenuLoop();
        }



        private void StartMenuLoop()
        {

           
            int XX = 0;
            void MoveRightX()
            {
                XX++;
            }

            void MoveLeftX()
            {
                XX--;
            }


            bool needToRender = true;

            do
            {
                while (Console.KeyAvailable || needToRender)
                {

                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();

                    switch (pressedChar.Key)
                    {

                        case ConsoleKey.RightArrow:
                            MoveRightX();
                            if (XX < 3)
                            {
                                Console.WriteLine(XX);
                                gameWindow.BeforeSetInact(XX - 1);
                                gameWindow.MoveToRightButton(XX);               
                            }
                            else
                            {

                                gameWindow.BeforeSetInact(XX - 2);
                                gameWindow.MoveToRightButton(XX - 1);
                                XX = 2;
                            }

                            break;
                        case ConsoleKey.LeftArrow:
                            MoveLeftX();
                            if (XX >= 0)
                            {
                                gameWindow.AfterSetInact(XX + 1);
                                gameWindow.MoveToLeftButton(XX);
                            }
                            else
                            {
                                gameWindow.AfterSetInact(XX + 2);
                                gameWindow.MoveToLeftButton(XX + 1);
                                XX = 0;
                            }
                            break;
                        case ConsoleKey.Enter:
                            if (XX == 0)
                            {
                                GameController gameController = new GameController();
                                gameController.StartGame();
                            }
                            else if (XX==1)
                            {
                                Console.Clear();
                                needToRender = false;
                                CreditWindow creditWindow = new CreditWindow();
                                creditWindow.Render();
                            }
                            else
                            {
                                Console.Clear();
                                Environment.Exit(1);
                            }
                            break;
                    }
                }
            } while (needToRender);
        }





    }
}
