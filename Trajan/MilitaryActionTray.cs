namespace Trajan
{
    public class MilitaryActionTray : Tray
    {
        public MilitaryActionTray(Player player) : base(player)
        {
            this.Action += player.Game.MilitaryAction;
        }

    }
}