// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return transactions that belong to the given card.
        /// </summary>
        [JsonProperty("card")]
        public string Card { get; set; }

        /// <summary>
        /// Only return transactions that belong to the given cardholder.
        /// </summary>
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return transactions that have the given type. One of <c>capture</c> or
        /// <c>refund</c>.
        /// One of: <c>capture</c>, or <c>refund</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
