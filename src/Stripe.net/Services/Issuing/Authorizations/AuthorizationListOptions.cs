namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return transactions that belong to the given cardholder.
        /// </summary>
        [JsonProperty("card")]
        public string Card { get; set; }

        /// <summary>
        /// Only return transactions that belong to the given card.
        /// </summary>
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return authorizations with the given status.  One of <c>closed</c>,
        /// <c>pending</c>, or <c>reversed</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
