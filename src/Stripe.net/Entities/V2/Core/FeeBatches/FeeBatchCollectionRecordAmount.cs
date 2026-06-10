// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeBatchCollectionRecordAmount : StripeEntity<FeeBatchCollectionRecordAmount>
    {
        /// <summary>
        /// A lowercase alpha3 currency code like "usd" For the taxonomy label choice, see
        /// SECURE_FRAMEWORKS-2849.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// In major units like "1.23" for 1.23 USD For the taxonomy label choice, see
        /// SECURE_FRAMEWORKS-2849.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
