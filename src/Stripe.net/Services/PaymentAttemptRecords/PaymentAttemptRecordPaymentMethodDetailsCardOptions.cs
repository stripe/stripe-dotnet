// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsCardOptions : INestedOptions
    {
        /// <summary>
        /// Verification checks performed on the card.
        /// </summary>
        [JsonProperty("checks")]
        [STJS.JsonPropertyName("checks")]
        public PaymentAttemptRecordPaymentMethodDetailsCardChecksOptions Checks { get; set; }

        /// <summary>
        /// Decline code from the card network for the failed payment.
        /// </summary>
        [JsonProperty("network_decline_code")]
        [STJS.JsonPropertyName("network_decline_code")]
        public string NetworkDeclineCode { get; set; }
    }
}
