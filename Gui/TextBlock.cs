using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Gui
{
    sealed class TextBlock : GuiObject
    {

        private List<TextLine> textBlocks = new List<TextLine>();

        public TextBlock(int x, int y, int width, List<string> textList) : base(x, y, width, 0)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                textBlocks.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }

        public override void Render()
        {
            for (int i = 0; i < textBlocks.Count; i++)
            {
                textBlocks[i].Render();
            }
        }

    }
}
