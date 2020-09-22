// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsSofort : StripeEntity<PaymentIntentPaymentMethodOptionsSofort>
    {
        /// <summary>
        /// Preferred language of the SOFORT authorization page that the customer is redirected to.
        /// One of: <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, <c>it</c>, <c>nl</c>, or <c>pl</c>.
        /// </summary>
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
