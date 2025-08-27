// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertCreditBalanceThresholdOptions : INestedOptions
    {
        /// <summary>
        /// The filters allows limiting the scope of this credit balance alert. You must specify a
        /// customer filter at this time.
        /// </summary>
        [JsonProperty("filters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filters")]
#endif
        public List<AlertCreditBalanceThresholdFilterOptions> Filters { get; set; }

        /// <summary>
        /// Defines at which value the alert will fire.
        /// </summary>
        [JsonProperty("lte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lte")]
#endif
        public AlertCreditBalanceThresholdLteOptions Lte { get; set; }
    }
}
