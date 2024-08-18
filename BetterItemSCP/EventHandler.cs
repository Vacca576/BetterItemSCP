using Exiled.API;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.Commands.PluginManager;
using Exiled.Events.EventArgs.Player;
using System.Collections.Generic;
using System.Linq;

namespace BetterItemSCP
{
    public class EventHandler
    {
        private readonly BetterItemSCP plugin;
        public void OnUsingItem(UsingItemCompletedEventArgs ev)
        {
            if (ev.Item.Type == ItemType.SCP500)

                if (plugin.Config.Better500)
                {
                    List<Effect> Effects500 = plugin.Config.Effects500;

                }
            if (ev.Item.Type == ItemType.SCP1853)
            
                if (plugin.Config.Better1853)
                {
                    List<Effect> Effects1853 = plugin.Config.Effects1853;
                }

            if (ev.Item.Type == ItemType.SCP018)

                if (plugin.Config.Better018)
                {
                    List<Effect> Effects018 = plugin.Config.Effects018;
                }
            
            if (ev.Item.Type == ItemType.SCP268)

                if (plugin.Config.Better268)
                {
                    List<Effect> Effects268 = plugin.Config.Effects268;
                }

            if (ev.Item.Type == ItemType.SCP207)

                if (plugin.Config.Better207)
                {
                    List<Effect> Effects207 = plugin.Config.Effects207;
                }
        }

    }
}
