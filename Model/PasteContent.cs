using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateBin.NET.Model {
    public class PasteContent {
        [JsonProperty("paste")]
        public string Paste { get; set; }
    }
}
