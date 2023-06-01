// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCustomFieldText : StripeEntity<SessionCustomFieldText>
    {
        /// <summary>
        /// The maximum character length constraint for the customer's input.
        /// </summary>
        [JsonProperty("maximum_length")]
        public long? MaximumLength { get; set; }

        /// <summary>
        /// The minimum character length requirement for the customer's input.
        /// </summary>
        [JsonProperty("minimum_length")]
        public long? MinimumLength { get; set; }

        /// <summary>
        /// The value entered by the customer.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
