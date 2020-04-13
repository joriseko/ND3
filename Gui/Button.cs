using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Gui
{
    class Button : GuiObject
    {
        public bool IsActive { get; private set; } = false;

        public string Label
        {
            get { return textLine.Label; }
            set { textLine.Label = value; }
        }

        private string label = "";

        private Frame notActiveFrame;
        private Frame activeFrame;
        private Frame frame;

        private TextLine textLine;

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            frame = new Frame(x, y, width, height, '+');
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');
           //notActiveFrame.RenderChar = '@';          
            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }

        public override void Render()
        {
            if (IsActive)
            {
                frame.RenderChar = '#';
                //activeFrame.Render();
            }
            else
            {
                frame.RenderChar = '+';
               // notActiveFrame.Render();
            }

            textLine.Render();
        }

        public void SetActive()
        {
            IsActive = true;
        }
        public void SetInactive()
        {
            IsActive = false;
        }

 


    }
}