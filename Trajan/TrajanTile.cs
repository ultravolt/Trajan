using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class TrajanTile
    {
        public enum TYPE
        {
            UNDEFINED,
            LABOR,
            MILITARY,
            VICTORY,
            CARDS,
            DEMAND,
            ACTION_EFFICIENCY
        }

        public TrajanTile.TYPE TrajanType { get; private set; }


        public TrajanTile(TrajanTile.TYPE type = TrajanTile.TYPE.UNDEFINED)
        {
            this.TrajanType = type;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(TrajanTile.TYPE), this.TrajanType);
        }


    }
}
