// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentStatusDetailsFailed : StripeEntity<OutboundPaymentStatusDetailsFailed>
    {
        /// <summary>
        /// Open Enum. The <c>failed</c> status reason.
        /// One of: <c>payout_method_declined</c>, <c>payout_method_does_not_exist</c>,
        /// <c>payout_method_expired</c>, <c>payout_method_unsupported</c>,
        /// <c>payout_method_usage_frequency_limit_exceeded</c>, or <c>unknown_failure</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
