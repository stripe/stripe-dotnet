// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleBillingScheduleBillUntilAmendmentEnd : StripeEntity<SubscriptionScheduleBillingScheduleBillUntilAmendmentEnd>
    {
        /// <summary>
        /// Use an index to specify the position of an amendment to end prebilling with.
        /// </summary>
        [JsonProperty("index")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("index")]
#endif
        public long Index { get; set; }
    }
}
