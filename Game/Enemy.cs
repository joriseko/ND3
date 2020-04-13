using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Units
{
    class Enemy:Unit
    {
        private int id;



        public Enemy(int id, int x, int y, string name):base(x, y, name)
        {
            this.id = id;
        }

        public void MoveDown()
        {
            Y++;
        }

   

        public int GetId()
        {
            return id;
        }



    }
}
