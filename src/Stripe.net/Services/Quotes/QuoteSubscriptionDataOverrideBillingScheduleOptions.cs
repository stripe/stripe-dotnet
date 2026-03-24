// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteSubscriptionDataOverrideBillingScheduleOptions : INestedOptions
    {
        /// <summary>
        /// Configure billing schedule differently for individual subscription items.
        /// </summary>
        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public List<QuoteSubscriptionDataOverrideBillingScheduleAppliesToOptions> AppliesTo { get; set; }

        /// <summary>
        /// The start of the period to bill from when the Quote is accepted.
        /// </summary>
        [JsonProperty("bill_from")]
        [STJS.JsonPropertyName("bill_from")]
        public QuoteSubscriptionDataOverrideBillingScheduleBillFromOptions BillFrom { get; set; }

        /// <summary>
        /// The end of the period to bill until when the Quote is accepted.
        /// </summary>
        [JsonProperty("bill_until")]
        [STJS.JsonPropertyName("bill_until")]
        public QuoteSubscriptionDataOverrideBillingScheduleBillUntilOptions BillUntil { get; set; }

        /// <summary>
        /// Specify a key for the billing schedule. Must be unique to this field, alphanumeric, and
        /// up to 200 characters. If not provided, a unique key will be generated.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
