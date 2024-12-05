// File generated from our OpenAPI spec
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
        /// Only return cardholders that have the given phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Only return cardholders that have the given status. One of <c>active</c>,
        /// <c>inactive</c>, or <c>blocked</c>.
        /// One of: <c>active</c>, <c>blocked</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return cardholders that have the given type. One of <c>individual</c> or
        /// <c>company</c>.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
