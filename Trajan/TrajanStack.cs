using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class TrajanStack : Stack<TrajanTile>
    {
        public TrajanStack(IEnumerable<TrajanTile> collection) : base(collection)
        {
        }
    }
    public class TrajanStacks : Dictionary<TrajanTile.TYPE,TrajanStack>
    {
        public TrajanStacks()
        {
            var types = Enum.GetValues(typeof(TrajanTile.TYPE)).Cast<TrajanTile.TYPE>().Where(x=>x!=TrajanTile.TYPE.UNDEFINED);            
            foreach (var type in types)
            {
                var dl = new List<TrajanTile>();
                for (int j = 0; j < 9; j++)
                    dl.Add(new TrajanTile(type));
                ListExtensions.Shuffle(dl);
                this[type] = new TrajanStack(dl);
            }

        }
    }
}
