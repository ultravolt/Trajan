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
    public class TrajanStacks : Dictionary<TrajanTile.TYPE, TrajanStack>
    {
        public TrajanStacks()
        {
            var types = Enum.GetValues(typeof(TrajanTile.TYPE)).Cast<TrajanTile.TYPE>();
            var pi = new Dictionary<TrajanTile.TYPE, List<TrajanTile>>();
            pi.Add(TrajanTile.TYPE.VICTORY, new List<TrajanTile>
                {
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.BLUE, ActionMarker.COLOR.BLUE, TrajanTile.POINT_VALUE.NINE),
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.ORANGE, TrajanTile.POINT_VALUE.NINE),
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.PINK, ActionMarker.COLOR.PINK, TrajanTile.POINT_VALUE.NINE),
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.GREEN, ActionMarker.COLOR.GREEN, TrajanTile.POINT_VALUE.NINE),
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.YELLOW, TrajanTile.POINT_VALUE.NINE),
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.WHITE, ActionMarker.COLOR.WHITE, TrajanTile.POINT_VALUE.NINE),
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.BLUE, ActionMarker.COLOR.WHITE, TrajanTile.POINT_VALUE.NINE),
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.WHITE, TrajanTile.POINT_VALUE.NINE),
                    new TrajanTile(TrajanTile.TYPE.VICTORY,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.WHITE, TrajanTile.POINT_VALUE.NINE)
                });

            pi.Add(TrajanTile.TYPE.ACTION_EFFICIENCY, new List<TrajanTile>
                {
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.PINK, ActionMarker.COLOR.BLUE),
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.PINK, ActionMarker.COLOR.ORANGE),
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.PINK, ActionMarker.COLOR.GREEN),
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.PINK, ActionMarker.COLOR.YELLOW),
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.PINK, ActionMarker.COLOR.WHITE),
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.PINK, ActionMarker.COLOR.WHITE),
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.PINK, ActionMarker.COLOR.PINK),
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.WHITE, ActionMarker.COLOR.WHITE),
                    new TrajanTile(TrajanTile.TYPE.ACTION_EFFICIENCY,ActionMarker.COLOR.GREEN, ActionMarker.COLOR.WHITE)
                });

            pi.Add(TrajanTile.TYPE.LABOR, new List<TrajanTile>
                {
                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.ORANGE, TrajanTile.POINT_VALUE.TWO, TrajanTile.WORKER_BONUS.TWO),
                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.YELLOW, TrajanTile.POINT_VALUE.TWO, TrajanTile.WORKER_BONUS.TWO),
                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.ORANGE, TrajanTile.POINT_VALUE.TWO, TrajanTile.WORKER_BONUS.TWO),
                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.BLUE, TrajanTile.POINT_VALUE.TWO, TrajanTile.WORKER_BONUS.TWO),

                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.GREEN, TrajanTile.POINT_VALUE.FIVE, TrajanTile.WORKER_BONUS.ONE),
                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.PINK, TrajanTile.POINT_VALUE.FIVE, TrajanTile.WORKER_BONUS.ONE),
                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.YELLOW, TrajanTile.POINT_VALUE.FIVE, TrajanTile.WORKER_BONUS.ONE),
                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.WHITE, TrajanTile.POINT_VALUE.FIVE, TrajanTile.WORKER_BONUS.ONE),
                    new TrajanTile(TrajanTile.TYPE.LABOR,ActionMarker.COLOR.BLUE, ActionMarker.COLOR.GREEN, TrajanTile.POINT_VALUE.FIVE, TrajanTile.WORKER_BONUS.ONE),

                });

            pi.Add(TrajanTile.TYPE.DEMAND, new List<TrajanTile>
                {
                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.GREEN, ActionMarker.COLOR.GREEN, DemandTile.TYPE.BREAD),
                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.GREEN, ActionMarker.COLOR.ORANGE, DemandTile.TYPE.BREAD),
                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.PINK, ActionMarker.COLOR.PINK, DemandTile.TYPE.BREAD),

                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.GREEN, ActionMarker.COLOR.GREEN, DemandTile.TYPE.GAMES),
                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.GREEN, ActionMarker.COLOR.YELLOW, DemandTile.TYPE.GAMES),
                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.GREEN, ActionMarker.COLOR.PINK, DemandTile.TYPE.GAMES),

                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.WHITE, ActionMarker.COLOR.WHITE, DemandTile.TYPE.RELIGION),
                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.GREEN, ActionMarker.COLOR.WHITE, DemandTile.TYPE.RELIGION),
                    new TrajanTile(TrajanTile.TYPE.DEMAND,ActionMarker.COLOR.BLUE, ActionMarker.COLOR.ORANGE, DemandTile.TYPE.RELIGION),
                });

            pi.Add(TrajanTile.TYPE.CARDS, new List<TrajanTile>
            {
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.BLUE, ActionMarker.COLOR.BLUE),
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.YELLOW),
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.ORANGE),
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.BLUE, ActionMarker.COLOR.WHITE),
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.BLUE, ActionMarker.COLOR.ORANGE),
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.YELLOW),
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.GREEN),
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.GREEN, ActionMarker.COLOR.PINK),
                    new TrajanTile(TrajanTile.TYPE.CARDS, ActionMarker.COLOR.WHITE, ActionMarker.COLOR.PINK),
                });

            pi.Add(TrajanTile.TYPE.MILITARY, new List<TrajanTile>
            {
                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.ORANGE, TrajanTile.POINT_VALUE.TWO, TrajanTile.LEGIONAIRE_BONUS.TWO),
                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.YELLOW, TrajanTile.POINT_VALUE.TWO, TrajanTile.LEGIONAIRE_BONUS.TWO),
                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.ORANGE, TrajanTile.POINT_VALUE.TWO, TrajanTile.LEGIONAIRE_BONUS.TWO),
                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.YELLOW, ActionMarker.COLOR.BLUE, TrajanTile.POINT_VALUE.TWO, TrajanTile.LEGIONAIRE_BONUS.TWO),

                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.GREEN, TrajanTile.POINT_VALUE.FIVE, TrajanTile.LEGIONAIRE_BONUS.ONE),
                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.PINK, TrajanTile.POINT_VALUE.FIVE, TrajanTile.LEGIONAIRE_BONUS.ONE),
                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.YELLOW, TrajanTile.POINT_VALUE.FIVE, TrajanTile.LEGIONAIRE_BONUS.ONE),
                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.ORANGE, ActionMarker.COLOR.WHITE, TrajanTile.POINT_VALUE.FIVE, TrajanTile.LEGIONAIRE_BONUS.ONE),
                    new TrajanTile(TrajanTile.TYPE.MILITARY,ActionMarker.COLOR.BLUE, ActionMarker.COLOR.GREEN, TrajanTile.POINT_VALUE.FIVE, TrajanTile.LEGIONAIRE_BONUS.ONE),

                     });
            foreach (var type in types)
            {
                var dl = pi[type];
                ListExtensions.Shuffle(dl);
                this[type] = new TrajanStack(dl);
            }

        }
    }
}
