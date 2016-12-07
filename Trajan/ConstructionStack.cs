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
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.DOOR, i+2));
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.FOUNTAIN, i+2));
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.ROOF, i+2));
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.STAIRS, i+2));
                dl.Add(new ConstructionTile(ConstructionTile.TYPE.WINDOW, i+2));

            }
            ListExtensions.Shuffle(dl);
            dl.Take(dl.Count).ToList().ForEach(x => this.Push(x));

        }
    }
}
