using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateBin.NET.Model {
    public class PasteRequestMeta {
        [JsonProperty("expire")]
        public string Expire { get; set; }
    }
}
