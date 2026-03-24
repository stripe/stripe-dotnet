// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancingOfferListOptions : ListOptions
    {
        /// <summary>
        /// limit list to offers belonging to given connected account.
        /// </summary>
        [JsonProperty("connected_account")]
        [STJS.JsonPropertyName("connected_account")]
        public string ConnectedAccount { get; set; }

        /// <summary>
        /// Only return offers that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// limit list to offers with given status.
        /// One of: <c>accepted</c>, <c>canceled</c>, <c>completed</c>, <c>delivered</c>,
        /// <c>expired</c>, <c>fully_repaid</c>, <c>paid_out</c>, <c>rejected</c>, <c>revoked</c>,
        /// or <c>undelivered</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
