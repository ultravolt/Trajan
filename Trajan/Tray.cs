using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class Tray
    {
        public List<ActionMarker> ActionMarkers { get; set; }
        public Func<Player, object> Action { get; set; }
        public Player Player { get; set; }
        public Tray(Player player)
        {
            this.Player = player;
            this.ActionMarkers = new List<ActionMarker>();
        }
        public void Select()
        {
            
            this.Action(Player);
        }

    }
}
