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
        public int ActionId { get; private set; }

        public Tray(Player player, int actionId)
        {
            this.ActionId = actionId;
            this.Player = player;
            this.ActionMarkers = new List<ActionMarker>();
        }

        public void PickUp()
        {
            ActionMarker[] am=new ActionMarker[ActionMarkers.Count];
            this.ActionMarkers.CopyTo(am);
            this.ActionMarkers.Clear();
            int x = this.ActionId;
            foreach(var a in am)
            {
                ++x;
                if (x > 5) x = 0;
                this.Player.Trays[x].ActionMarkers.Add(a);
            }

            var final=this.Player.Trays[x];
            //throw new NotImplementedException();
        }

        public void Select()
        {
            
            this.Action(Player);
        }
        public override string ToString()
        {
            return $@"{this.GetType()}, {this.ActionMarkers.Count}";
        }
    }
}
