// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreatePaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// The merchant category code for this transaction. Used in interchange and authorization
        /// to improve auth rates.
        /// </summary>
        [JsonProperty("mcc")]
        [STJS.JsonPropertyName("mcc")]
        public string Mcc { get; set; }

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
        [STJS.JsonPropertyName("network_transaction_id")]
        public string NetworkTransactionId { get; set; }
    }
}
