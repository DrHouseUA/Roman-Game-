﻿using System;
using System.Text;



namespace Roman_Game_
{
    class Program
    {

        static void Main(string[] args)
        {
            int consWidth = 120;
            int consHeight = 30;
            char Line = ' ';
           

            Console.Title = "Game";
            Console.SetWindowSize(consWidth, consHeight);
            Console.SetBufferSize(consWidth, consHeight);
            Console.CursorVisible = false;



            char[] symb = new char[consWidth * consHeight];

            for (int i = 0; i < consHeight * consWidth - 1; i++)
            {
                symb[i] = Line;
            };



            Graphics.DrawChart(consWidth,consHeight);

            ObjPos objPos = new ();
            objPos.x = Console.GetCursorPosition().Left;
            objPos.y=Console.GetCursorPosition().Top;
            //'x'Console.WriteLine($"{Graphics.ObjPos.x} " + y"  {Graphics.ObjPos.y}"); для понимания позиции

            Console.ReadKey();
            

        }

        
        


            
            


    }
}

