using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class BonusStack : Stack<BonusTile>
    {
        //Todo: Add Actual Bonus Tile Definitions and enums
        public BonusStack()
        {
            var dl = new List<BonusTile>();
            for (int i = 0; i < 12; i++)
                dl.Add(new BonusTile());
            ListExtensions.Shuffle(dl);
            dl.ForEach(x => this.Push(x));
        }
    }
}
