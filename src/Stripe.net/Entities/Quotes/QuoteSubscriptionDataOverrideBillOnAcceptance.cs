// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionDataOverrideBillOnAcceptance : StripeEntity<QuoteSubscriptionDataOverrideBillOnAcceptance>
    {
        /// <summary>
        /// The start of the period to bill from when the Quote is accepted.
        /// </summary>
        [JsonProperty("bill_from")]
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillFrom BillFrom { get; set; }

        /// <summary>
        /// The end of the period to bill until when the Quote is accepted.
        /// </summary>
        [JsonProperty("bill_until")]
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntil BillUntil { get; set; }
    }
}
