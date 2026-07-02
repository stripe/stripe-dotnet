// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxFundContext : StripeEntity<TaxFundContext>
    {
        /// <summary>
        /// The Checkout Session associated with this sweep, if any.
        /// </summary>
        [JsonProperty("checkout_session")]
        [STJS.JsonPropertyName("checkout_session")]
        public string CheckoutSession { get; set; }

        /// <summary>
        /// The Credit Note associated with this sweep, if any.
        /// </summary>
        [JsonProperty("credit_note")]
        [STJS.JsonPropertyName("credit_note")]
        public string CreditNote { get; set; }

        /// <summary>
        /// The Invoice associated with this sweep, if any.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// The PaymentIntent associated with this sweep, if any.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// The Refund associated with this sweep, if any.
        /// </summary>
        [JsonProperty("refund")]
        [STJS.JsonPropertyName("refund")]
        public string Refund { get; set; }

        /// <summary>
        /// The Tax Transaction associated with this sweep, if any.
        /// </summary>
        [JsonProperty("tax_transaction")]
        [STJS.JsonPropertyName("tax_transaction")]
        public string TaxTransaction { get; set; }
    }
}
