// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertCreditBalanceThreshold : StripeEntity<AlertCreditBalanceThreshold>
    {
        /// <summary>
        /// The filters allow limiting the scope of this credit balance alert. You must specify only
        /// a customer filter at this time.
        /// </summary>
        [JsonProperty("filters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filters")]
#endif
        public List<AlertCreditBalanceThresholdFilter> Filters { get; set; }

        [JsonProperty("lte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lte")]
#endif
        public AlertCreditBalanceThresholdLte Lte { get; set; }
    }
}
