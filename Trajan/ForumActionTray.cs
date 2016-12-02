namespace Trajan
{
    public class ForumActionTray : Tray
    {
        public ForumActionTray(Player player) : base(player)
        {
            this.Action += player.Game.ForumAction;
        }

    }
}