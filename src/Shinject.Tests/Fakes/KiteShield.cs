using Shinject.Tests.Fakes;

namespace Shinject.Tests.Integration
{
    using System.Runtime.InteropServices;
    using Shinject.Tests.Fakes;

    public class KiteShield
    {
        public KiteShield([DefaultParameterValue(ShieldColor.Orange)] ShieldColor color)
        {
            this.Color = color;
        }

        public ShieldColor Color { get; set; }
    }
}