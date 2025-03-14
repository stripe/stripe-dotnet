// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceAttachPaymentIntentOptions : BaseOptions
    {
        /// <summary>
        /// The portion of the PaymentIntent’s <c>amount</c> that should be applied to thisinvoice.
        /// Defaults to the entire amount.
        /// </summary>
        [JsonProperty("amount_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_requested")]
#endif
        public long? AmountRequested { get; set; }

        /// <summary>
        /// The ID of the PaymentIntent to attach to the invoice.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }
    }
}
