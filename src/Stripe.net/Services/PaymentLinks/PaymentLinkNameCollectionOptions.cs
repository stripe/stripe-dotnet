// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkNameCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Controls settings applied for collecting the customer's business name.
        /// </summary>
        [JsonProperty("business")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business")]
#endif
        public PaymentLinkNameCollectionBusinessOptions Business { get; set; }

        /// <summary>
        /// Controls settings applied for collecting the customer's individual name.
        /// </summary>
        [JsonProperty("individual")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual")]
#endif
        public PaymentLinkNameCollectionIndividualOptions Individual { get; set; }
    }
}
