// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCustomFieldNumeric : StripeEntity<SessionCustomFieldNumeric>
    {
        /// <summary>
        /// The value entered by the customer, containing only digits.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
