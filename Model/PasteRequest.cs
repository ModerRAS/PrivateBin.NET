using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateBin.NET.Model {
    public class PasteRequest {
        [JsonProperty("v")]
        public int V { get; set; }
        [JsonProperty("adata")]
        public dynamic AData { get; set; }
        [JsonProperty("meta")]
        public PasteRequestMeta Meta { get; set; }
        [JsonProperty("ct")]
        public string CT { get; set; }
    }
}
