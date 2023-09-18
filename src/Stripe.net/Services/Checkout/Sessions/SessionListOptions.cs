// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionListOptions : ListOptions
    {
        /// <summary>
        /// Only return the Checkout Sessions for the Customer specified.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions for the Customer details specified.
        /// </summary>
        [JsonProperty("customer_details")]
        public SessionCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// Only return the Checkout Session for the PaymentIntent specified.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions for the Payment Link specified.
        /// </summary>
        [JsonProperty("payment_link")]
        public string PaymentLink { get; set; }

        /// <summary>
        /// Only return the Checkout Session for the subscription specified.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
