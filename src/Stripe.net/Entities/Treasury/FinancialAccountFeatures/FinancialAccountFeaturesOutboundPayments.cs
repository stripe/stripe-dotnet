// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountFeaturesOutboundPayments : StripeEntity<FinancialAccountFeaturesOutboundPayments>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling an ACH specific feature.
        /// </summary>
        [JsonProperty("ach")]
        public FinancialAccountFeaturesOutboundPaymentsAch Ach { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
        public FinancialAccountFeaturesOutboundPaymentsUsDomesticWire UsDomesticWire { get; set; }
    }
}
