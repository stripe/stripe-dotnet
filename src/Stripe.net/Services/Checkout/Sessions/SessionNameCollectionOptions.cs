// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionNameCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Controls settings applied for collecting the customer's business name on the session.
        /// </summary>
        [JsonProperty("business")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business")]
#endif
        public SessionNameCollectionBusinessOptions Business { get; set; }

        /// <summary>
        /// Controls settings applied for collecting the customer's individual name on the session.
        /// </summary>
        [JsonProperty("individual")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual")]
#endif
        public SessionNameCollectionIndividualOptions Individual { get; set; }
    }
}
