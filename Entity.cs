using System;
using static Roman_Game_.ObjPos;


namespace Roman_Game_
{
    abstract class Entity
    {
      
        public ObjPos pos = new();
        protected Entity(int x, int y)
        {
            pos.x = x;
            pos.y = y;

        }
        abstract public char GetSymb(char Symb);


    }

}
