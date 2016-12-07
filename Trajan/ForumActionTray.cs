namespace Trajan
{
    public class ForumActionTray : Tray
    {
        public ForumActionTray(Player player, int actionId) : base(player, actionId)
        {
            this.Action += player.Game.ForumAction;
        }

    }
}