// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionNameCollection : StripeEntity<SessionNameCollection>
    {
        [JsonProperty("business")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business")]
#endif
        public SessionNameCollectionBusiness Business { get; set; }

        [JsonProperty("individual")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual")]
#endif
        public SessionNameCollectionIndividual Individual { get; set; }
    }
}
