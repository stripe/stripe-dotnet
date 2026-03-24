// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2BillingRateCardRateCreatedEventData : StripeEntity<V2BillingRateCardRateCreatedEventData>
    {
        /// <summary>
        /// The ID of the BillableItem which this Rate is associated with.
        /// </summary>
        [JsonProperty("billable_item")]
        [STJS.JsonPropertyName("billable_item")]
        public string BillableItem { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the RateCard which this Rate belongs to.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the latest RateCard Version when the Rate was created.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }
    }
}
