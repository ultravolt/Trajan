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
        public ActionMarker[] ActionMarkers { get; set; }
        public PlayerToken[] PlayerTokens { get; set; }
        public LeaderToken LeaderToken { get; set; }
        public Player()
        {
            this.LeaderToken = new LeaderToken();
            this.PlayerTokens = new PlayerToken[PLAYER_TOKEN_COUNT];
            for (int i = 0; i < PLAYER_TOKEN_COUNT; i++)
                this.PlayerTokens[i] = new PlayerToken();
            var amc = new List<ActionMarker.COLOR> { ActionMarker.COLOR.BLUE, ActionMarker.COLOR.GREEN, ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.PINK, ActionMarker.COLOR.WHITE, ActionMarker.COLOR.YELLOW };
            ActionMarkers = new ActionMarker[amc.Count * 2];
            for (int i=0;i<amc.Count;i++)
            {
                this.ActionMarkers[i * 2] = new ActionMarker(amc[i]);
                this.ActionMarkers[(i * 2) + 1] = new ActionMarker(amc[i]);
            }
        }
    }
}
