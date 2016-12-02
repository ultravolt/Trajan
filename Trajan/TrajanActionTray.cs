namespace Trajan
{
    public class TrajanActionTray : Tray
    {
        public TrajanActionTray(Player player) : base(player)
        {
            this.Action += player.Game.TrajanAction;
        }
    }
}