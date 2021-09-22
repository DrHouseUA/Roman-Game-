using System;
using System.Text;



namespace Roman_Game_
{
    class Program
    {

        private static void Main(string[] args)
        {

            int consWidth = 120;
            int consHeight = 30;
            char Line = ' ';
            

            Console.Title = "Game";
            Console.SetWindowSize(consWidth, consHeight);
            Console.SetBufferSize(consWidth, consHeight);
            ObjPos.width = Console.BufferWidth - 2;
            ObjPos.height = Console.BufferHeight - 2;
            Console.CursorVisible = false;


            char[] symb = new char[consWidth * consHeight];

            for (int i = 0; i < consHeight * consWidth - 1; i++)
            {
                symb[i] = Line;
            };

            Graphics.DrawChart(consWidth,consHeight);

            ObjPos objPos = new();
            objPos.x = Console.GetCursorPosition().Left;
            objPos.y = Console.GetCursorPosition().Top;

            TypeOfFire missle1 = new(3, 3, "5");

            Console.ReadKey();

        }
    }
}

