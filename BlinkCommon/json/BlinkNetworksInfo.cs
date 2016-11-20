using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkSharp
{
    class BlinkNetworksInfo
    {
        public BlinkNetworksSummary summary { get; set; }
        public BlinkNetwork[] networks { get; set; }
    }
}
