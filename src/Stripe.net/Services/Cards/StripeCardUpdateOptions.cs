using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCardUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("exp_month")]
        public int? ExpirationMonth { get; set; }

        [JsonProperty("exp_year")]
        public int? ExpirationYear { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
