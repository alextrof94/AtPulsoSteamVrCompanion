using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtPulsoSteamVrCompanion
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Preset
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deviceId")]
        public int DeviceId { get; set; }

        [JsonProperty("size")]
        public decimal Size { get; set; }

        [JsonProperty("opacity")]
        public decimal Opacity { get; set; }

        [JsonProperty("x")]
        public decimal X { get; set; }
        [JsonProperty("y")]
        public decimal Y { get; set; }
        [JsonProperty("z")]
        public decimal Z { get; set; }

        [JsonProperty("pitch")]
        public decimal Pitch { get; set; }
        [JsonProperty("yaw")]
        public decimal Yaw { get; set; }
        [JsonProperty("roll")]
        public decimal Roll { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
