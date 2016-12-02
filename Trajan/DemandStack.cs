using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class DemandStack : Stack<DemandTile>
    {
        public DemandStack()
        {
            var dl = new List<DemandTile>();
            for (int i = 0; i < 5; i++)
            {
                dl.Add(new DemandTile(DemandTile.TYPE.BREAD));
                dl.Add(new DemandTile(DemandTile.TYPE.GAMES));
                dl.Add(new DemandTile(DemandTile.TYPE.RELIGION));
            }
            ListExtensions.Shuffle(dl);
            dl.Take(dl.Count-3).ToList().ForEach(x => this.Push(x));

        }
    }
}
