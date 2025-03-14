// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataOverrideBillOnAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// The start of the period to bill from when the Quote is accepted.
        /// </summary>
        [JsonProperty("bill_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_from")]
#endif
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillFromOptions BillFrom { get; set; }

        /// <summary>
        /// The end of the period to bill until when the Quote is accepted.
        /// </summary>
        [JsonProperty("bill_until")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_until")]
#endif
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilOptions BillUntil { get; set; }
    }
}
