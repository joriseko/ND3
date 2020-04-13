using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Gui
{
    class GameWindow : Window
    {
       
        private Button startButton;
        private Button creditButton;
        private Button quitButton;
        private TextBlock titleTextBlock;

        private Button myButton;
        public List<Button> buttons = new List<Button>();

        public GameWindow() : base(0, 0, 120, 30, '%')
        {

            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });
           startButton = new Button(20, 13, 18, 5, "Start");
           startButton.SetActive();
           creditButton = new Button(50, 13, 18, 5, "Credits");
           quitButton = new Button(80, 13, 18, 5, "Quit");

            buttons.Add(new Button(20, 13, 18, 5, "Start"));
            buttons.Add(new Button(50, 13, 18, 5, "Credits"));
            buttons.Add(new Button(80, 13, 18, 5, "Quit"));
        }


       

        public void MoveToRightButton(int y)
        {
            buttons[y].SetActive();
            buttons[y].Render();
        }

        public void BeforeSetInact(int y)
        {
            buttons[y].SetInactive();
            buttons[y].Render();
        }

        public void MoveToLeftButton(int y)
        {
            buttons[y].SetActive();
            buttons[y].Render();
        }

        public void AfterSetInact(int y)
        {
            buttons[y].SetInactive();
            buttons[y].Render();
        }

        public override void Render()
        {
            titleTextBlock.Render();
            startButton.Render();
            creditButton.Render();
            quitButton.Render();
    
            Console.SetCursorPosition(0, 0);
        }





    
        
    }
}
