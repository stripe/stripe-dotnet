// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsLink : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsLink>
    {
        /// <summary>
        /// Two-letter ISO code representing the funding source country beneath the Link payment.
        /// You could use this attribute to get a sense of international fees.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }
    }
}
