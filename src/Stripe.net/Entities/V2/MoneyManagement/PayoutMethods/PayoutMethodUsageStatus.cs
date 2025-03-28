// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodUsageStatus : StripeEntity<PayoutMethodUsageStatus>
    {
        /// <summary>
        /// Payments status.
        /// One of: <c>eligible</c>, <c>invalid</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public string Payments { get; set; }

        /// <summary>
        /// Transfers status.
        /// One of: <c>eligible</c>, <c>invalid</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfers")]
#endif
        public string Transfers { get; set; }
    }
}
