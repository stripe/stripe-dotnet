// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionCardAwaitNotification : StripeEntity<PaymentIntentNextActionCardAwaitNotification>
    {
        /// <summary>
        /// The time that payment will be attempted. If customer approval is required, they need to
        /// provide approval before this time.
        /// </summary>
        [JsonProperty("charge_attempt_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_attempt_at")]
#endif

        public DateTime? ChargeAttemptAt { get; set; }

        /// <summary>
        /// For payments greater than INR 15000, the customer must provide explicit approval of the
        /// payment with their bank. For payments of lower amount, no customer action is required.
        /// </summary>
        [JsonProperty("customer_approval_required")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_approval_required")]
#endif

        public bool? CustomerApprovalRequired { get; set; }
    }
}
