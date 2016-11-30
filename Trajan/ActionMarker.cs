using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class ActionMarker
    {
        public COLOR Color { get; set; }

        public ActionMarker(COLOR cOLOR)
        {
            this.Color = cOLOR;
        }

        public enum COLOR
        {
            PINK,
            ORANGE,
            YELLOW,
            WHITE,
            GREEN,
            BLUE
        }


        public override string ToString()
        {
            return Enum.GetName(typeof(ActionMarker.COLOR), this.Color);
        }
    }
}
