// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreatePaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// If you are making a Credential On File transaction with a previously saved card, you
        /// should pass the Network Transaction ID from a prior initial authorization on Stripe
        /// (from a successful SetupIntent or a PaymentIntent with <c>setup_future_usage</c> set),
        /// or one that you have obtained from another payment processor. This is a token from the
        /// network which uniquely identifies the transaction. Visa calls this the Transaction ID,
        /// Mastercard calls this the Trace ID, and American Express calls this the Acquirer
        /// Reference Data. Note that you should pass in a Network Transaction ID if you have one,
        /// regardless of whether this is a Customer-Initiated Transaction (CIT) or a
        /// Merchant-Initiated Transaction (MIT).
        /// </summary>
        [JsonProperty("network_transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_transaction_id")]
#endif
        public string NetworkTransactionId { get; set; }
    }
}
