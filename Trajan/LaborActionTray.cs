namespace Trajan
{
    public class LaborActionTray : Tray
    {
        public LaborActionTray(Player player, int actionId) : base(player, actionId)
        {
            this.Action += player.Game.LaborAction;
        }

    }
}