using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class CommodityCard
    {
        public TYPE CommodityType { get; private set; }

        public CommodityCard(TYPE type)
        {
            this.CommodityType = type;
        }

        public enum TYPE
        {
            WINE,
            SHEEP,
            HIDE,
            OIL,
            LAMP,
            COLUMN,
            JEWELRY,
            WHEAT,
            FISH,
            GEM,
            SCROLL,
            FRUIT
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(CommodityCard.TYPE), this.CommodityType);
        }

    }
}
