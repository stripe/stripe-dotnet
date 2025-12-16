// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewPayto : StripeEntity<ConfirmationTokenPaymentMethodPreviewPayto>
    {
        /// <summary>
        /// Bank-State-Branch number of the bank account.
        /// </summary>
        [JsonProperty("bsb_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bsb_number")]
#endif
        public string BsbNumber { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// The PayID alias for the bank account.
        /// </summary>
        [JsonProperty("pay_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_id")]
#endif
        public string PayId { get; set; }
    }
}
