// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewPayto : StripeEntity<ConfirmationTokenPaymentMethodPreviewPayto>
    {
        /// <summary>
        /// Bank-State-Branch number of the bank account.
        /// </summary>
        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The PayID alias for the bank account.
        /// </summary>
        [JsonProperty("pay_id")]
        public string PayId { get; set; }
    }
}
