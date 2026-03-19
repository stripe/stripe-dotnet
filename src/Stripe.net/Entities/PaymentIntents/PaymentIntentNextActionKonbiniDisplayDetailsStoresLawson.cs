// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionKonbiniDisplayDetailsStoresLawson : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetailsStoresLawson>
    {
        /// <summary>
        /// The confirmation number.
        /// </summary>
        [JsonProperty("confirmation_number")]
        [STJS.JsonPropertyName("confirmation_number")]
        public string ConfirmationNumber { get; set; }

        /// <summary>
        /// The payment code.
        /// </summary>
        [JsonProperty("payment_code")]
        [STJS.JsonPropertyName("payment_code")]
        public string PaymentCode { get; set; }
    }
}
