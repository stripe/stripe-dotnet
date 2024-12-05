// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsBancontactOptions : INestedOptions
    {
        /// <summary>
        /// Preferred language of the Bancontact authorization page that the customer is redirected
        /// to.
        /// One of: <c>de</c>, <c>en</c>, <c>fr</c>, or <c>nl</c>.
        /// </summary>
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
