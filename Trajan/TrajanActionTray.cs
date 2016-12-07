namespace Trajan
{
    public class TrajanActionTray : Tray
    {
        public TrajanActionTray(Player player, int actionId) : base(player, actionId)
        {
            this.Action += player.Game.TrajanAction;
        }
    }
}