// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsBoleto : StripeEntity<PaymentIntentPaymentMethodOptionsBoleto>
    {
        /// <summary>
        /// The number of calendar days before a Boleto voucher expires. For example, if you create
        /// a Boleto voucher on Monday and you set expires_after_days to 2, the Boleto voucher will
        /// expire on Wednesday at 23:59 America/Sao_Paulo time.
        /// </summary>
        [JsonProperty("expires_after_days")]
        public long ExpiresAfterDays { get; set; }
    }
}
