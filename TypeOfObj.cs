using System;


namespace Roman_Game_
{
    class TypeOfObj : Entity
    {
        public int X, Y;
        public char Symb;
        public TypeOfObj(int x, int y, char symb)
            : base(x, y)
        {
            X = x;
            Y = y;
            GetSymb(symb);
        }

        public override char GetSymb(char symb)
        {
            Symb = symb;
            return Symb;
        }

    }
}
