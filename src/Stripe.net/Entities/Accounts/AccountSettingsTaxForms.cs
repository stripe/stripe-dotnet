// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsTaxForms : StripeEntity<AccountSettingsTaxForms>
    {
        /// <summary>
        /// Whether the account opted out of receiving their tax forms by postal delivery.
        /// </summary>
        [JsonProperty("consented_to_paperless_delivery")]
        [STJS.JsonPropertyName("consented_to_paperless_delivery")]
        public bool ConsentedToPaperlessDelivery { get; set; }
    }
}
