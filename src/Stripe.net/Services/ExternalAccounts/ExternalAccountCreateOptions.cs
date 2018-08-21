namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ExternalAccountCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("external_account")]
        public string ExternalAccountTokenId { get; set; }

        [JsonProperty("external_account")]
        public StripeAccountBankAccountOptions ExternalAccountBankAccount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }
    }
}
