namespace Trajan
{
    public class SenateActionTray : Tray
    {
        public SenateActionTray(Player player, int actionId) : base(player, actionId)
        {
            this.Action += player.Game.SenateAction;
        }

    }
}