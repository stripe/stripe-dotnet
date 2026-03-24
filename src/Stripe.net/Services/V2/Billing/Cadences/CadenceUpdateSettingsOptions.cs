// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CadenceUpdateSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Settings that configure bills generation, which includes calculating totals, tax, and
        /// presenting invoices. If null is provided, the current bill settings will be removed from
        /// the billing cadence.
        /// </summary>
        [JsonProperty("bill")]
        [STJS.JsonPropertyName("bill")]
        public CadenceUpdateSettingsBillOptions Bill { get; set; }

        /// <summary>
        /// Settings that configure and manage the behavior of collecting payments. If null is
        /// provided, the current collection settings will be removed from the billing cadence.
        /// </summary>
        [JsonProperty("collection")]
        [STJS.JsonPropertyName("collection")]
        public CadenceUpdateSettingsCollectionOptions Collection { get; set; }
    }
}
