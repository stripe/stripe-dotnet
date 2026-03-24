// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionListOptions : ListOptions
    {
        /// <summary>
        /// Only return transactions that belong to the given card.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public string Card { get; set; }

        /// <summary>
        /// Only return transactions that belong to the given cardholder.
        /// </summary>
        [JsonProperty("cardholder")]
        [STJS.JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return transactions that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return transactions that are associated with the given settlement.
        /// </summary>
        [JsonProperty("settlement")]
        [STJS.JsonPropertyName("settlement")]
        public string Settlement { get; set; }

        /// <summary>
        /// Only return transactions that have the given type. One of <c>capture</c> or
        /// <c>refund</c>.
        /// One of: <c>capture</c>, or <c>refund</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
