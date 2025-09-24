// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentPaymentsOrchestration : StripeEntity<OffSessionPaymentPaymentsOrchestration>
    {
        /// <summary>
        /// True when you want to enable payments orchestration for this off-session payment. False
        /// otherwise.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }
    }
}
