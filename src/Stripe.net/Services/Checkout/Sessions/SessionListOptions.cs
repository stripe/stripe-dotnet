// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("customer_details")]
        public SessionCustomerDetailsOptions CustomerDetails { get; set; }

        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonProperty("payment_link")]
        public string PaymentLink { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
