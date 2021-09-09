using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Game_
{
    class Graphics
    {
        int topleft = 218;
        const int hline = 196;
        int topright = 191;
        int vline = 179;
        int bottomleft = 192;
        int bottomright = 217;
        public static void DrawChart(int x)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);

            for (int i = 1; i < x-1; i++)
            {
               Write(hline); 
                
            }
        }

         static void Write (int charcode)
        {
            Console.Write((char)charcode);
        }
    }
}
