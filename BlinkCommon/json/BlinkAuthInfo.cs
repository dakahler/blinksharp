using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkSharp
{
    class BlinkAuthInfo
    {
        public BlinkAuthToken authtoken { get; set; }
        public BlinkNetworksInfo networks { get; set; }
        public BlinkRegion region { get; set; }
    }
}
