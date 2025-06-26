// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodOptionsKlarna : StripeEntity<SetupIntentPaymentMethodOptionsKlarna>
    {
        /// <summary>
        /// The currency of the setup intent. Three letter ISO currency code.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Preferred locale of the Klarna checkout page that the customer is redirected to.
        /// </summary>
        [JsonProperty("preferred_locale")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_locale")]
#endif
        public string PreferredLocale { get; set; }
    }
}
