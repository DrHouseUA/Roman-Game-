using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Game_
{
    class Graphics
    {
        const char topleft = '╔';
        const char hline = '═';
        const char topright = '╗';
        const char vline = '║';
        const char bottomleft = '╚';

        public static void DrawChart(int x,int y)
        {
           
            Write(topleft);

            for (int i = 0; i < x-2; i++)
            {
               Write(hline);                 
            }

            Write(topright);

            for(int i = 1; i < y-1; i++)
            {
                Console.SetCursorPosition(0, i);
                Write(vline);                
            }

            Console.SetCursorPosition(0, y-1);
            Write(bottomleft);

            for (int i = 1; i < y - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Write(vline);
                Console.SetCursorPosition(x-1, i);
                Write(vline);
            }


            Console.SetCursorPosition(1, y-1);
            for (int i = x*(y-1); i < x*y - 2; i++)
            {
                
                Write(hline);
            }
        }

         static void Write (char charsymb)
        {
            Console.Write(charsymb);
        }
    }
}
