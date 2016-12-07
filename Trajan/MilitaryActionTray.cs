namespace Trajan
{
    public class MilitaryActionTray : Tray
    {
        public MilitaryActionTray(Player player, int actionId) : base(player, actionId)
        {
            this.Action += player.Game.MilitaryAction;
        }

    }
}