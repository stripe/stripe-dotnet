// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCurrentAttempt : StripeEntity<SessionCurrentAttempt>, IHasId
    {
        /// <summary>
        /// The customer's billing information, if provided.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public SessionCurrentAttemptBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The customer's email.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The attempt ID you will pass to the <a href="api/checkout/sessions/approve">Checkout
        /// Session approve</a> endpoint to approve the attempt.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Information about the payment method the customer is attempting to pay with. Relevant
        /// payment method information is provided when available. Some payment details are only
        /// available after the payment has completed and can't be returned in the manual approval
        /// flow.
        /// </summary>
        [JsonProperty("payment_method_details")]
        [STJS.JsonPropertyName("payment_method_details")]
        public SessionCurrentAttemptPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The customer's shipping information, if provided.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public SessionCurrentAttemptShippingDetails ShippingDetails { get; set; }
    }
}
