namespace Trajan
{
    public class Board
    {
        public ConstructionTile[,] ConstructionSites { get; private set; }   

        public Board()
        {
            ConstructionSites = new ConstructionTile[4, 5];
        }
    }
}