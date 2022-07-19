// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Customer's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
