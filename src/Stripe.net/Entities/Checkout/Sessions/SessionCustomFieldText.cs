// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCustomFieldText : StripeEntity<SessionCustomFieldText>
    {
        /// <summary>
        /// The value entered by the customer.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
