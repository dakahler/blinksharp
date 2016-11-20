using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkSharp
{
    class BlinkNetworkEvents
    {
        [JsonProperty(PropertyName = "event")]
        public BlinkEvent[] _event { get; set; }
    }
}
