// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfigurationTippingGbp : StripeEntity<ConfigurationTippingGbp>
    {
        /// <summary>
        /// Fixed amounts displayed when collecting a tip.
        /// </summary>
        [JsonProperty("fixed_amounts")]
        public List<long> FixedAmounts { get; set; }

        /// <summary>
        /// Percentages displayed when collecting a tip.
        /// </summary>
        [JsonProperty("percentages")]
        public List<long> Percentages { get; set; }

        /// <summary>
        /// Below this amount, fixed amounts will be displayed; above it, percentages will be
        /// displayed.
        /// </summary>
        [JsonProperty("smart_tip_threshold")]
        public long SmartTipThreshold { get; set; }
    }
}
