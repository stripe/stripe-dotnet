// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceUpdateSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Settings that configure bills generation, which includes calculating totals, tax, and
        /// presenting invoices. If null is provided, the current bill settings will be removed from
        /// the billing cadence.
        /// </summary>
        [JsonProperty("bill")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill")]
#endif
        public CadenceUpdateSettingsBillOptions Bill { get; set; }

        /// <summary>
        /// Settings that configure and manage the behavior of collecting payments. If null is
        /// provided, the current collection settings will be removed from the billing cadence.
        /// </summary>
        [JsonProperty("collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection")]
#endif
        public CadenceUpdateSettingsCollectionOptions Collection { get; set; }
    }
}
