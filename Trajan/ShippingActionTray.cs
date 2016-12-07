using System;

namespace Trajan
{
    public class ShippingActionTray : Tray
    {
        public ShippingActionTray(Player player, int actionId) : base(player, actionId)
        {
            this.Action += player.Game.ShippingAction;
        }

    }
}