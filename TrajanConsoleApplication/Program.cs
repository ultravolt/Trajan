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
                Debug.WriteLine(game);
            }

        }
    }
}
