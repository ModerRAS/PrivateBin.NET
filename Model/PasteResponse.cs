using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateBin.NET.Model {
    public class PasteResponse {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("deletetoken")]
        public string DeleteToken { get; set; }
    }
}
