using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterItemSCP
{
    public class Config : IConfig
    {
        [Description("Plugin is Enabled?.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug is Enabled?.")]
        public bool Debug { get; set; } = false;
    }
}
