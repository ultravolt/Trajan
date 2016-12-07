using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Trajan;
using System.Diagnostics;

namespace TrajanConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game=new Game(Game.NUMBER_OF_PLAYERS.FOUR))
            {
                game.Players.FirstOrDefault().Trays[0].PickUp();
                game.Players.FirstOrDefault().Trays[2].PickUp();
                game.Players.FirstOrDefault().Trays[4].PickUp();

                Debug.WriteLine(game);
            }

        }
    }
}
