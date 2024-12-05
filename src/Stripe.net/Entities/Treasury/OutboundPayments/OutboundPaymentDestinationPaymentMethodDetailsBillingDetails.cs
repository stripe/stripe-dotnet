// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentDestinationPaymentMethodDetailsBillingDetails : StripeEntity<OutboundPaymentDestinationPaymentMethodDetailsBillingDetails>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Full name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
