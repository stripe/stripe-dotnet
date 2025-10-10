// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkNameCollection : StripeEntity<PaymentLinkNameCollection>
    {
        [JsonProperty("business")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business")]
#endif
        public PaymentLinkNameCollectionBusiness Business { get; set; }

        [JsonProperty("individual")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual")]
#endif
        public PaymentLinkNameCollectionIndividual Individual { get; set; }
    }
}
