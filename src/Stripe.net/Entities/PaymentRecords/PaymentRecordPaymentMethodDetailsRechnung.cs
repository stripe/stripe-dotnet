// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsRechnung : StripeEntity<PaymentRecordPaymentMethodDetailsRechnung>
    {
        /// <summary>
        /// Payment portal URL.
        /// </summary>
        [JsonProperty("payment_portal_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_portal_url")]
#endif
        public string PaymentPortalUrl { get; set; }
    }
}
