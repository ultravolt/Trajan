using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Trajan
{
    

    public class CommodityDeck : Stack<CommodityCard>
    {


        public CommodityDeck()
        {
            var l = new List<CommodityCard>();
            var types = new List<CommodityCard.TYPE>
            {
                CommodityCard.TYPE.WINE,
                CommodityCard.TYPE.SHEEP,
                CommodityCard.TYPE.HIDE,
                CommodityCard.TYPE.OIL,
                CommodityCard.TYPE.LAMP,
                CommodityCard.TYPE.COLUMN,
                CommodityCard.TYPE.JEWELRY,
                CommodityCard.TYPE.WHEAT,
                CommodityCard.TYPE.FISH,
                CommodityCard.TYPE.GEM,
                CommodityCard.TYPE.SCROLL,
                CommodityCard.TYPE.FRUIT
            };
            for (int i = 0; i < types.Count; i++)
                for (int j = 0; j < 5; j++)
                    l.Add(new CommodityCard(types[i]));
            ListExtensions.Shuffle(l);
            l.ForEach(x => this.Push(x));
        }
    }
}
