// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentPaymentMethodOptionsKlarna : StripeEntity<SetupIntentPaymentMethodOptionsKlarna>
    {
        /// <summary>
        /// The currency of the setup intent. Three letter ISO currency code.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Preferred locale of the Klarna checkout page that the customer is redirected to.
        /// </summary>
        [JsonProperty("preferred_locale")]
        [STJS.JsonPropertyName("preferred_locale")]
        public string PreferredLocale { get; set; }
    }
}
