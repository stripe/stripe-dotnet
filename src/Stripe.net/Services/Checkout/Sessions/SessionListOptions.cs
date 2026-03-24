// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionListOptions : ListOptions
    {
        /// <summary>
        /// Only return Checkout Sessions that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions for the Customer specified.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions for the Account specified.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions for the Customer details specified.
        /// </summary>
        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public SessionCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// Only return the Checkout Session for the PaymentIntent specified.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions for the Payment Link specified.
        /// </summary>
        [JsonProperty("payment_link")]
        [STJS.JsonPropertyName("payment_link")]
        public string PaymentLink { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions matching the given status.
        /// One of: <c>complete</c>, <c>expired</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return the Checkout Session for the subscription specified.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
