using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Game_
{
    struct ObjPos
    {
        public int x;
        public int y;
   

        public ObjPos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public ObjPos GetDirCoords( int dir)
        {
            ObjPos objPos = new();

            switch(dir)
            {
                case 0:
                    objPos.x = x;
                    objPos.y = y - 1;
                    return objPos;
                case 1:
                    objPos.x = x+1;
                    objPos.y = y-1;
                    return objPos;
                case 2:
                    objPos.x = x+1;
                    objPos.y = y;
                    return objPos;
                case 3:
                    objPos.x = x+1;
                    objPos.y = y+1;
                    return objPos;
                case 4:
                    objPos.x = x;
                    objPos.y = y+1;
                    return objPos;
                case 5:
                    objPos.x = x+1;
                    objPos.y = y+1;
                    return objPos;
                case 6:
                    objPos.x = x-1;
                    objPos.y = y;
                    return objPos;
                case 7:
                    objPos.x = x-1;
                    objPos.y = y-1;
                    return objPos;

            }

            return objPos;

        }

    }
}
