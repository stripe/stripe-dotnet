// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFeaturesOutboundPayments : StripeEntity<FinancialAccountFeaturesOutboundPayments>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling an ACH specific feature.
        /// </summary>
        [JsonProperty("ach")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach")]
#endif

        public FinancialAccountFeaturesOutboundPaymentsAch Ach { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_domestic_wire")]
#endif

        public FinancialAccountFeaturesOutboundPaymentsUsDomesticWire UsDomesticWire { get; set; }
    }
}
