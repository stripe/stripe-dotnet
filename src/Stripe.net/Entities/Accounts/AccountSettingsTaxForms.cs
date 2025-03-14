// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsTaxForms : StripeEntity<AccountSettingsTaxForms>
    {
        /// <summary>
        /// Whether the account opted out of receiving their tax forms by postal delivery.
        /// </summary>
        [JsonProperty("consented_to_paperless_delivery")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consented_to_paperless_delivery")]
#endif
        public bool ConsentedToPaperlessDelivery { get; set; }
    }
}
