using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class Game : IDisposable
    {
        public Board Board { get; private set; }
        public Player[] Players { get; private set; }
        public CommodityDeck CommodityDeck { get; private set; }
        public DemandStack DemandStack { get; private set; }
        public ConstructionStack ConstructionStack { get; private set; }
        public BonusStack BonusStack { get; private set; }
        public TrajanStacks TrajanStacks { get; private set; }

        public Game(NUMBER_OF_PLAYERS number)
        {
            this.Players = new Player[(int)number];
            this.BonusStack = new BonusStack();
            int i = 0;
            for (i = 0; i < (int)number; i++)
            {
                this.Players[i] = new Player(this);
                this.Players[i].BonusTiles.Add(this.BonusStack.Pop());
            }
            this.CommodityDeck = new CommodityDeck();
            this.DemandStack = new DemandStack();
            this.ConstructionStack = new ConstructionStack();
            this.Board = new Board();
            for (int r = 0; r < 4; r++)
                for (int c=0; c< 5; c++)
                    Board.ConstructionSites[r, c] = this.ConstructionStack.Pop();
            this.TrajanStacks = new TrajanStacks();
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

        public object ShippingAction(Player player)
        {
            throw new NotImplementedException();
        }

        public object MilitaryAction(Player player)
        {
            throw new NotImplementedException();
        }

        public object TrajanAction(Player player)
        {
            throw new NotImplementedException();
        }

        public object LaborAction(Player player)
        {
            throw new NotImplementedException();
        }

        public object SenateAction(Player player)
        {
            throw new NotImplementedException();
        }

        public object ForumAction(Player player)
        {
            throw new NotImplementedException();
        }
    }

}
