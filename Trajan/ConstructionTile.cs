using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class ConstructionTile
    {
        public TYPE ConstructionType { get; private set; }

        public enum TYPE
        {
            STAIRS,
            DOOR,
            FOUNTAIN,
            ROOF,
            WINDOW
        }

        public ConstructionTile(ConstructionTile.TYPE type)
        {
            this.ConstructionType = type;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(ConstructionTile.TYPE), this.ConstructionType);
        }
    }
}
