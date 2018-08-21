namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ExternalAccountUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("external_account")]
        public ExternalAccountCardUpdateOptions ExternalAccountCard { get; set; }
    }
}
