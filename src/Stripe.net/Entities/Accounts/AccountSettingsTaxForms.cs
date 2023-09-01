// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsTaxForms : StripeEntity<AccountSettingsTaxForms>
    {
        /// <summary>
        /// Whether the account opted out of receiving their tax forms by postal delivery.
        /// </summary>
        [JsonProperty("consented_to_paperless_delivery")]
        public bool ConsentedToPaperlessDelivery { get; set; }
    }
}
