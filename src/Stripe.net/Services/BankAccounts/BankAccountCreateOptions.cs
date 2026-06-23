namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class BankAccountCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<string, SourceBankAccount> Source { get; set; }
    }
}
