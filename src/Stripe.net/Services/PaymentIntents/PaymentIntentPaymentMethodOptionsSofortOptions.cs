// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsSofortOptions : INestedOptions
    {
        /// <summary>
        /// Language shown to the payer on redirect.
        /// One of: <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, <c>it</c>, <c>nl</c>, or <c>pl</c>.
        /// </summary>
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
