// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertCreditBalanceThresholdOptions : INestedOptions
    {
        /// <summary>
        /// The filters allows limiting the scope of this credit balance alert. You must specify a
        /// customer filter at this time.
        /// </summary>
        [JsonProperty("filters")]
        [STJS.JsonPropertyName("filters")]
        public List<AlertCreditBalanceThresholdFilterOptions> Filters { get; set; }

        /// <summary>
        /// Defines at which value the alert will fire.
        /// </summary>
        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        public AlertCreditBalanceThresholdLteOptions Lte { get; set; }
    }
}
