namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ExternalAccountCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("external_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, AccountBankAccountOptions> ExternalAccount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
