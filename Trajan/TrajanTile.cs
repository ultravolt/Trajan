using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajan
{
    public class TrajanTile : Tuple<ActionMarker.COLOR, ActionMarker.COLOR>
    {

        public enum WORKER_BONUS
        {
            ONE = 1,
            TWO = 2
        }

        public enum LEGIONAIRE_BONUS
        {
            ONE = 1,
            TWO = 2
        }

        public enum POINT_VALUE
        {
            ONE = 1,
            TWO = 2,
            THREE = 3,
            FOUR = 4,
            FIVE = 5,
            NINE = 9
        }

        public enum TYPE
        {
            LABOR,
            MILITARY,
            VICTORY,
            CARDS,
            DEMAND,
            ACTION_EFFICIENCY
        }
        public POINT_VALUE Points { get; set; }
        public LEGIONAIRE_BONUS LegionaireBonus { get; private set; }
        public WORKER_BONUS WorkerBonus { get; private set; }
        public DemandTile.TYPE DemandType { get; private set; }
        

        public TrajanTile.TYPE TrajanType { get; private set; }


        public TrajanTile(TrajanTile.TYPE type, ActionMarker.COLOR i1, ActionMarker.COLOR i2) : base(i1, i2)
        {
            this.TrajanType = type;
        }
        public TrajanTile(TrajanTile.TYPE type, ActionMarker.COLOR i1, ActionMarker.COLOR i2, DemandTile.TYPE demandType) : base(i1, i2)
        {
            this.TrajanType = type;
            this.DemandType = demandType;
        }
        public TrajanTile(TrajanTile.TYPE type, ActionMarker.COLOR item1, ActionMarker.COLOR item2, POINT_VALUE pointValue) : base(item1, item2)
        {
            this.TrajanType = type;
            this.Points = pointValue;
        }

        public TrajanTile(TrajanTile.TYPE type, ActionMarker.COLOR item1, ActionMarker.COLOR item2, POINT_VALUE pointValue, WORKER_BONUS workerBonus) : base(item1, item2)
        {
            this.TrajanType = type;
            this.Points = pointValue;
            this.WorkerBonus = workerBonus;
        }

        public TrajanTile(TrajanTile.TYPE type, ActionMarker.COLOR item1, ActionMarker.COLOR item2, POINT_VALUE pointValue, LEGIONAIRE_BONUS legionaireBonus) : base(item1, item2)
        {
            this.TrajanType = type;
            this.Points = pointValue;
            this.LegionaireBonus = legionaireBonus;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(TrajanTile.TYPE), this.TrajanType);
        }


    }
}
