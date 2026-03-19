namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("default_for_currency")]
        [STJS.JsonPropertyName("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        [JsonProperty("validate")]
        [STJS.JsonPropertyName("validate")]
        public bool? Validate { get; set; }
    }
}
