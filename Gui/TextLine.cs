using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Gui
{
    class TextLine : GuiObject
    {

        private string label;

        public TextLine(int x, int y, int width, string label) : base(x, y, width, 0)
        {
            Label = label;
        }

        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
                Render();
            }
        }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            if (Width > Label.Length)
            {
                int offset = (Width - Label.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }
            Console.Write(Label);
        }


    }
}
