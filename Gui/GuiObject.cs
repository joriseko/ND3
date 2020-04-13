using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Gui
{
    abstract class GuiObject
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        abstract public void Render();
    
    }
}
