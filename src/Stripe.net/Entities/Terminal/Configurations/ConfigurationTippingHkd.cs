// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationTippingHkd : StripeEntity<ConfigurationTippingHkd>
    {
        /// <summary>
        /// Fixed amounts displayed when collecting a tip.
        /// </summary>
        [JsonProperty("fixed_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fixed_amounts")]
#endif
        public List<long> FixedAmounts { get; set; }

        /// <summary>
        /// Percentages displayed when collecting a tip.
        /// </summary>
        [JsonProperty("percentages")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percentages")]
#endif
        public List<long> Percentages { get; set; }

        /// <summary>
        /// Below this amount, fixed amounts will be displayed; above it, percentages will be
        /// displayed.
        /// </summary>
        [JsonProperty("smart_tip_threshold")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("smart_tip_threshold")]
#endif
        public long SmartTipThreshold { get; set; }
    }
}
