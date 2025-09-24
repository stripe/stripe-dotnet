// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceBillingCycleDay : StripeEntity<CadenceBillingCycleDay>
    {
        /// <summary>
        /// The time at which the billing cycle ends.
        /// </summary>
        [JsonProperty("time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time")]
#endif
        public CadenceBillingCycleDayTime Time { get; set; }
    }
}
