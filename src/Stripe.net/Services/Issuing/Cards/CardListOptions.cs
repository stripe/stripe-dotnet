namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return cards belonging to the given cardholder.
        /// </summary>
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return cards that have the given expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Only return cards that have the given expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Only return cards that have the given last four digits.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Only return cards that have the given status. One of <c>active</c>, <c>canceled</c>,
        /// <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// nly return cards that have the given type. One of <c>physical</c> or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
