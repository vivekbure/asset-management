using Newtonsoft.Json;

namespace AssetManagement.WebGatewayAPI.Controllers.SchemeInfoController.Models
{
    public class SchemeInfo
    {
        [JsonProperty("Scheme Code")]
        public string SchemeCode { get; set; }

        [JsonProperty("ISIN Div Payout/ISIN Growth")]
        public string ISINDivPayoutISINGrowth { get; set; }

        [JsonProperty("ISIN Div Reinvestment")]
        public string ISINDivReinvestment { get; set; }

        [JsonProperty("Scheme Name")]
        public string SchemeName { get; set; }

        [JsonProperty("Net Asset Value")]
        public string NetAssetValue { get; set; }
        public string Date { get; set; }

        [JsonProperty("Scheme Type")]
        public string SchemeType { get; set; }

        [JsonProperty("Scheme Category")]
        public string SchemeCategory { get; set; }

        [JsonProperty("Mutual Fund Family")]
        public string MutualFundFamily { get; set; }
    }
}
