// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteSubscriptionDataBillOnAcceptance : StripeEntity<QuoteSubscriptionDataBillOnAcceptance>
    {
        /// <summary>
        /// The start of the period to bill from when the Quote is accepted.
        /// </summary>
        [JsonProperty("bill_from")]
        [STJS.JsonPropertyName("bill_from")]
        public QuoteSubscriptionDataBillOnAcceptanceBillFrom BillFrom { get; set; }

        /// <summary>
        /// The end of the period to bill until when the Quote is accepted.
        /// </summary>
        [JsonProperty("bill_until")]
        [STJS.JsonPropertyName("bill_until")]
        public QuoteSubscriptionDataBillOnAcceptanceBillUntil BillUntil { get; set; }
    }
}
