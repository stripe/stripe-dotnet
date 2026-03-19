// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CadenceCreateSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Settings that configure bill generation, which includes calculating totals, tax, and
        /// presenting invoices. If no setting is provided here, the settings from the customer
        /// referenced on the payer will be used. If no customer settings are present, the merchant
        /// default settings will be used.
        /// </summary>
        [JsonProperty("bill")]
        [STJS.JsonPropertyName("bill")]
        public CadenceCreateSettingsBillOptions Bill { get; set; }

        /// <summary>
        /// Settings that configure and manage the behavior of collecting payments. If no setting is
        /// provided here, the settings from the customer referenced from the payer will be used if
        /// they exist. If no customer settings are present, the merchant default settings will be
        /// used.
        /// </summary>
        [JsonProperty("collection")]
        [STJS.JsonPropertyName("collection")]
        public CadenceCreateSettingsCollectionOptions Collection { get; set; }
    }
}
