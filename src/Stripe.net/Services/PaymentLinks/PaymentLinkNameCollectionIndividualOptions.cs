// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkNameCollectionIndividualOptions : INestedOptions
    {
        /// <summary>
        /// Enable individual name collection on the payment link. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether the customer is required to provide their full name before checking out.
        /// Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("optional")]
#endif
        public bool? Optional { get; set; }
    }
}
