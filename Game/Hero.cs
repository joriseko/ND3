using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Units
{
    class Hero : Unit
    {


        public Hero(int x, int y, string name) : base(x, y, name)
        {

        }

        public void MoveRight()
        {
            X++;
        }

        public void MoveLeft()
        {
            X--;
        }


        public int GetX()
        {
            return X;
        }


    }
}
