// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomart : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomart>
    {
        /// <summary>
        /// The confirmation number.
        /// </summary>
        [JsonProperty("confirmation_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmation_number")]
#endif

        public string ConfirmationNumber { get; set; }

        /// <summary>
        /// The payment code.
        /// </summary>
        [JsonProperty("payment_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_code")]
#endif

        public string PaymentCode { get; set; }
    }
}
