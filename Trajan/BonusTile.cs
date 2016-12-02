using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class BonusTile
    {
        public BonusTile.TYPE BonusType { get; private set; }

        public enum TYPE
        {
            UNDEFINED
        }

        public BonusTile(BonusTile.TYPE type= BonusTile.TYPE.UNDEFINED)
        {
            this.BonusType = type;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(BonusTile.TYPE), this.BonusType);
        }

    }
}
