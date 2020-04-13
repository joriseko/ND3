using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Gui
{
    sealed class CreditWindow : Window
    {

        private Button backButton;

        private TextBlock creditTextBlock;
  

        public CreditWindow():base(28, 10, 60, 18, '@')
        {
            List<String> creditData = new List<string>();

            creditData.Add("");
            creditData.Add("Game design:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("Programuotojas:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("\'Art\':");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("Marketingas:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");

            creditTextBlock = new TextBlock(28 + 1, 10 + 1, 60 - 1, creditData);


            backButton = new Button(28 + 20, 10 + 14, 18, 3, "Back");
            backButton.SetActive();
        }

        public override void Render()
        {
            Console.Clear();
            base.Render();
            creditTextBlock.Render();
            backButton.Render();


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
                        case ConsoleKey.Enter:
                            Console.Clear();
                            GuiController guiController = new GuiController();
                            guiController.ShowMenu();
                            break;

                    }
                }    
                Console.SetCursorPosition(0, 0);
            } while (needToRender);
        }
    }
}
