// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsOxxo : StripeEntity<PaymentIntentPaymentMethodOptionsOxxo>
    {
        /// <summary>
        /// The number of calendar days before an OXXO invoice expires. For example, if you create
        /// an OXXO invoice on Monday and you set expires_after_days to 2, the OXXO invoice will
        /// expire on Wednesday at 23:59 America/Mexico_City time.
        /// </summary>
        [JsonProperty("expires_after_days")]
        public long ExpiresAfterDays { get; set; }
    }
}
