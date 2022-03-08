// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistop : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistop>
    {
        /// <summary>
        /// The confirmation number.
        /// </summary>
        [JsonProperty("confirmation_number")]
        public string ConfirmationNumber { get; set; }

        /// <summary>
        /// The payment code.
        /// </summary>
        [JsonProperty("payment_code")]
        public string PaymentCode { get; set; }
    }
}
