// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxFundContext : StripeEntity<TaxFundContext>
    {
        [JsonProperty("checkout_session")]
        [STJS.JsonPropertyName("checkout_session")]
        public string CheckoutSession { get; set; }

        [JsonProperty("credit_note")]
        [STJS.JsonPropertyName("credit_note")]
        public string CreditNote { get; set; }

        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonProperty("refund")]
        [STJS.JsonPropertyName("refund")]
        public string Refund { get; set; }

        [JsonProperty("tax_transaction")]
        [STJS.JsonPropertyName("tax_transaction")]
        public string TaxTransaction { get; set; }
    }
}
