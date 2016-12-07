using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class Player
    {
        private const int PLAYER_TOKEN_COUNT = 60;
        public enum Colors
        {
            RED,
            GREEN,
            BLUE,
            BROWN
        }
        public int Score { get; set; }
        //public ActionMarker[] ActionMarkers { get; set; }
        public PlayerToken[] PlayerTokens { get; set; }
        public LeaderToken LeaderToken { get; set; }
        public List<BonusTile> BonusTiles { get; set; }

        public Tray[] Trays { get; set; }
        public Game Game { get; private set; }

        public Player(Game game)
        {
            this.Game = game;
            this.BonusTiles = new List<BonusTile>();
            this.LeaderToken = new LeaderToken();
            this.PlayerTokens = new PlayerToken[PLAYER_TOKEN_COUNT];
            for (int i = 0; i < PLAYER_TOKEN_COUNT; i++)
                this.PlayerTokens[i] = new PlayerToken();
            var amc = new List<ActionMarker.COLOR> { ActionMarker.COLOR.BLUE, ActionMarker.COLOR.GREEN, ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.PINK, ActionMarker.COLOR.WHITE, ActionMarker.COLOR.YELLOW };
            var am = new List<ActionMarker>();// new ActionMarker[amc.Count * 2];
            for (int i=0;i<amc.Count;i++)
            {
                am.Add(new ActionMarker(amc[i]));
                am.Add(new ActionMarker(amc[i]));
            }
            {
                int i = 0;
                Trays = new Tray[6];
                Trays[i] = new ShippingActionTray(this, i);
                Trays[++i] = new ForumActionTray(this, i);
                Trays[++i] = new MilitaryActionTray(this, i);
                Trays[++i] = new SenateActionTray(this, i);
                Trays[++i] = new TrajanActionTray(this, i);
                Trays[++i] = new LaborActionTray(this, i);
            }
            //Randomly distribute the Action Markers to the trays
            //TODO: This should be player's choice
            ListExtensions.Shuffle(am);
            var sam = new Stack<ActionMarker>(am);
            {
                int i = 0;
                while (sam.Any())
                {
                    Trays[i].ActionMarkers.Add(sam.Pop());
                    Trays[i].ActionMarkers.Add(sam.Pop());
                    i++;
                }
            }




        }
    }
}
