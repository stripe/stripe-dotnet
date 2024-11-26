// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetails : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetails>
    {
        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresent CardPresent { get; set; }

        /// <summary>
        /// The type of payment method transaction-specific details from the transaction that
        /// generated this <c>card</c> payment method. Always <c>card_present</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
