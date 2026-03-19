// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentProcessingCardCustomerNotification : StripeEntity<PaymentIntentProcessingCardCustomerNotification>
    {
        /// <summary>
        /// Whether customer approval has been requested for this payment. For payments greater than
        /// INR 15000 or mandate amount, the customer must provide explicit approval of the payment
        /// with their bank.
        /// </summary>
        [JsonProperty("approval_requested")]
        [STJS.JsonPropertyName("approval_requested")]
        public bool? ApprovalRequested { get; set; }

        /// <summary>
        /// If customer approval is required, they need to provide approval before this time.
        /// </summary>
        [JsonProperty("completes_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("completes_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CompletesAt { get; set; }
    }
}
