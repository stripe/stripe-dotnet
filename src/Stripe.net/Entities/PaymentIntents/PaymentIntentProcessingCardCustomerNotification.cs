// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentProcessingCardCustomerNotification : StripeEntity<PaymentIntentProcessingCardCustomerNotification>
    {
        /// <summary>
        /// Whether customer approval has been requested for this payment. For payments greater than
        /// INR 15000 or mandate amount, the customer must provide explicit approval of the payment
        /// with their bank.
        /// </summary>
        [JsonProperty("approval_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("approval_requested")]
#endif

        public bool? ApprovalRequested { get; set; }

        /// <summary>
        /// If customer approval is required, they need to provide approval before this time.
        /// </summary>
        [JsonProperty("completes_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("completes_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? CompletesAt { get; set; }
    }
}
