using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkSharp
{
    class BlinkEvent
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string type { get; set; }
        public bool notified { get; set; }
        public object duration { get; set; }
        public object status { get; set; }
        public object command_id { get; set; }
        public int? camera_id { get; set; }
        public object siren_id { get; set; }
        public int? sync_module_id { get; set; }
        public object network_id { get; set; }
        public int account_id { get; set; }
        public int? syncmodule { get; set; }
        public int? camera { get; set; }
        public object siren { get; set; }
        public string camera_name { get; set; }
        public int account { get; set; }
        public int video_id { get; set; }
        public string video_url { get; set; }
    }
}
