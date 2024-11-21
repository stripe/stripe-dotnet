// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return payouts that are expected to arrive during the given date interval.
        /// </summary>
        [JsonProperty("arrival_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrival_date")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif

        public AnyOf<DateTime?, DateRangeOptions> ArrivalDate { get; set; }

        /// <summary>
        /// The ID of an external account - only return payouts sent to this external account.
        /// </summary>
        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
#endif

        public string Destination { get; set; }

        /// <summary>
        /// Only return payouts that have the given status: <c>pending</c>, <c>paid</c>,
        /// <c>failed</c>, or <c>canceled</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }
    }
}
