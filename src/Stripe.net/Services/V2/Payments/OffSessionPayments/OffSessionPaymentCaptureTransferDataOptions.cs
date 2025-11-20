// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCaptureTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount transferred to the destination account. This transfer will occur
        /// automatically after the payment succeeds. If no amount is specified, by default the
        /// entire payment amount is transferred to the destination account. The amount must be less
        /// than or equal to the <a
        /// href="https://docs.stripe.com/api/v2/off-session-payments/object?api-version=2025-05-28.preview#v2_off_session_payment_object-amount_requested">amount_requested</a>,
        /// and must be a positive integer representing how much to transfer in the smallest
        /// currency unit (e.g., 100 cents to charge $1.00).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }
    }
}
