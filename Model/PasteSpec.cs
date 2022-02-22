using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateBin.NET.Model {
    public class PasteSpec {
        public string IV { get; set; }
        public string Salt { get; set; }
        public int Interations { get; set; }
        public int KeySize { get; set; }
        public int TagSize { get; set; }
        public string Algorithm { get; set; }
        public string Mode { get; set; }
        public string Compression { get; set; }
    }
}
