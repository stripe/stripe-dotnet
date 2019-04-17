namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return cardholders that have the given email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Only return the default cardholder.
        /// </summary>
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Only return cardholders that have the given phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Only return cardholders that have the given status. One of <c>active</c>,
        /// <c>inactive</c>, or <c>blocked</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return cardholders that have the given type. One of <c>individual</c> or
        /// <c>business_entity</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
