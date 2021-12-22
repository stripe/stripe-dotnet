// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Preferred language of the Klarna authorization page that the customer is redirected to.
        /// One of: <c>da-DK</c>, <c>de-AT</c>, <c>de-DE</c>, <c>en-AT</c>, <c>en-BE</c>,
        /// <c>en-DE</c>, <c>en-DK</c>, <c>en-ES</c>, <c>en-FI</c>, <c>en-FR</c>, <c>en-GB</c>,
        /// <c>en-IE</c>, <c>en-IT</c>, <c>en-NL</c>, <c>en-NO</c>, <c>en-SE</c>, <c>en-US</c>,
        /// <c>es-ES</c>, <c>es-US</c>, <c>fi-FI</c>, <c>fr-BE</c>, <c>fr-FR</c>, <c>it-IT</c>,
        /// <c>nb-NO</c>, <c>nl-BE</c>, <c>nl-NL</c>, <c>sv-FI</c>, or <c>sv-SE</c>.
        /// </summary>
        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }
    }
}
