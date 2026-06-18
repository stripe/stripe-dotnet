// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCancelOptions : BaseOptions
    {
        /// <summary>
        /// Per-pricing-line proration behavior overrides. Falls back to <c>proration_behavior</c>
        /// if not specified for a given line.
        /// </summary>
        [JsonProperty("cancel_pricing_lines")]
        [STJS.JsonPropertyName("cancel_pricing_lines")]
        public List<ContractCancelCancelPricingLineOptions> CancelPricingLines { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>contract_line_details</c>, <c>license_quantities</c>, <c>one_time_fees</c>,
        /// <c>pricing_lines</c>, or <c>pricing_overrides</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Top-level proration behavior for the cancellation. Defaults to <c>prorated</c> if not
        /// set.
        /// One of: <c>none</c>, or <c>prorated</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
