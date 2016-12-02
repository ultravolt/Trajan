namespace Trajan
{
    public class LaborActionTray : Tray
    {
        public LaborActionTray(Player player) : base(player)
        {
            this.Action += player.Game.LaborAction;
        }

    }
}