using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class DemandTile
    {
        public TYPE DemandType { get; private set; }

        public enum TYPE
        {
            BREAD,
            GAMES,
            RELIGION
        }

        public DemandTile(DemandTile.TYPE type)
        {
            this.DemandType = type;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(DemandTile.TYPE), this.DemandType);
        }
    }
}
