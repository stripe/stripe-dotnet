// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBancontact : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsBancontact>
    {
        /// <summary>
        /// Preferred language of the Bancontact authorization page that the customer is redirected
        /// to.
        /// One of: <c>de</c>, <c>en</c>, <c>fr</c>, or <c>nl</c>.
        /// </summary>
        [JsonProperty("preferred_language")]
        [STJS.JsonPropertyName("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
