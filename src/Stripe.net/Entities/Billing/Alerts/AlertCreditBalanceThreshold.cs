// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertCreditBalanceThreshold : StripeEntity<AlertCreditBalanceThreshold>
    {
        /// <summary>
        /// The filters allow limiting the scope of this credit balance alert. You must specify only
        /// a customer filter at this time.
        /// </summary>
        [JsonProperty("filters")]
        [STJS.JsonPropertyName("filters")]
        public List<AlertCreditBalanceThresholdFilter> Filters { get; set; }

        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        public AlertCreditBalanceThresholdLte Lte { get; set; }
    }
}
