namespace Trajan
{
    public class SenateActionTray : Tray
    {
        public SenateActionTray(Player player) : base(player)
        {
            this.Action += player.Game.SenateAction;
        }

    }
}