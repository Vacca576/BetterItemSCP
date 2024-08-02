using Exiled.Events.EventArgs.Player;

namespace BetterItemSCP
{
    public class EventHandler
    {
        public void OnUsingItem(UsingItemCompletedEventArgs ev)
        {
            if (ev.Item.Type == ItemType.SCP500)
            {
                ev.Player.EnableEffect(Exiled.API.Enums.EffectType.Invigorated, 15f);
                ev.Player.EnableEffect(Exiled.API.Enums.EffectType.MovementBoost, 15f);
                ev.Player.AddAhp(amount: 75, sustain: 15, decay: 5);

            }
            if (ev.Item.Type == ItemType.SCP1853)
            {
                ev.Player.EnableEffect(Exiled.API.Enums.EffectType.DamageReduction, 15f);
                ev.Player.EnableEffect(Exiled.API.Enums.EffectType.MovementBoost, 15f);
                ev.Player.EnableEffect(Exiled.API.Enums.EffectType.Invisible, 7f);
                ev.Player.AddAhp(amount: 75, sustain: 15, decay: 5);
            }


        } 

}
}
