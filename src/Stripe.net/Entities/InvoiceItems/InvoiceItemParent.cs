// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceItemParent : StripeEntity<InvoiceItemParent>
    {
        [JsonProperty("subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_details")]
#endif
        public InvoiceItemParentSubscriptionDetails SubscriptionDetails { get; set; }

        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
