using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeExternalAccountUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("external_account")]
        public StripeExternalAccountCardUpdateOptions ExternalAccountCard { get; set; }
    }
}
