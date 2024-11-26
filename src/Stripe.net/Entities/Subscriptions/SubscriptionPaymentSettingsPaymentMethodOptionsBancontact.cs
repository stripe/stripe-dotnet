// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsBancontact : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsBancontact>
    {
        /// <summary>
        /// Preferred language of the Bancontact authorization page that the customer is redirected
        /// to.
        /// One of: <c>de</c>, <c>en</c>, <c>fr</c>, or <c>nl</c>.
        /// </summary>
        [JsonProperty("preferred_language")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_language")]
#endif
        public string PreferredLanguage { get; set; }
    }
}
