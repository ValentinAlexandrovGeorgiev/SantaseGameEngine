﻿using Santase.Logic;
using Santase.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase.ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = 18;
            Console.BufferWidth = Console.WindowWidth = 60;

            ISantaceGame game = new SantaceGame(new ConsolePlayer(5,10), new ConsolePlayer(10,10), 
                PlayerPosition.FirstPlayer);

            game.Start();

            Console.WriteLine("Game finished" );
            Console.WriteLine("{0} - {1}", game.FirstPlayerTotalPoints, game.SecondPlayerTotalPoints);
            Console.WriteLine("Rounds : {0}", game.RoundsPlayed);
        }
    }
}
