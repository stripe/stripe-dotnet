// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentAttemptRecordPaymentMethodDetailsCustom : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCustom>
    {
        /// <summary>
        /// Display name for the custom (user-defined) payment method type used to make this
        /// payment.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The custom payment method type associated with this payment.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
