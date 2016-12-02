using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class ConstructionStack : Stack<ConstructionTile>
    {
        public ConstructionStack()
        {
            var dl = new List<ConstructionTile>();
            for (int i = 0; i < 4; i++)
            {
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.DOOR));
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.FOUNTAIN));
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.ROOF));
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.STAIRS));
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.WINDOW));

            }
            ListExtensions.Shuffle(dl);
            dl.Take(dl.Count).ToList().ForEach(x => this.Push(x));

        }
    }
}
