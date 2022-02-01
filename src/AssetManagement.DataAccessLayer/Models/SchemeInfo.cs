using System;
using System.Collections.Generic;

#nullable disable

namespace AssetManagement.DataAccessLayer.Models
{
    public partial class SchemeInfo
    {
        public int SerialNo { get; set; }
        public int SchemeCode { get; set; }
        public string SchemeName { get; set; }
        public string Amc { get; set; }
        public string NetAssetValue { get; set; }
        public DateTime Date { get; set; }
    }
}
