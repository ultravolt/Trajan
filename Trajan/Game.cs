using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class Game : IDisposable
    {
        public Player[] Players { get; private set; }
        public CommodityDeck CommodityDeck { get; private set; }

        public Game(NUMBER_OF_PLAYERS number)
        {
            this.Players = new Player[(int)number];
            for (int i = 0; i < (int)number;i++)
                this.Players[i] = new Player();
            this.CommodityDeck = new CommodityDeck();
        }

        public enum NUMBER_OF_PLAYERS
        {
            TWO=2,
            THREE=3,
            FOUR=4
        }
        public void Dispose()
        {
            
        }
    }

}
