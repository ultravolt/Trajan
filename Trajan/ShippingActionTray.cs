using System;

namespace Trajan
{
    public class ShippingActionTray : Tray
    {
        public ShippingActionTray(Player player) : base(player)
        {
            this.Action += player.Game.ShippingAction;
        }

    }
}