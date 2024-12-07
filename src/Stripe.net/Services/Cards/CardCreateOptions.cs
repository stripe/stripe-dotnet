namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("default_for_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_for_currency")]
#endif
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        [JsonProperty("validate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validate")]
#endif
        public bool? Validate { get; set; }
    }
}
