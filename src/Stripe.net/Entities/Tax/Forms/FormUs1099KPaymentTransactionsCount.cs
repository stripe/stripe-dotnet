// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormUs1099KPaymentTransactionsCount : StripeEntity<FormUs1099KPaymentTransactionsCount>
    {
        /// <summary>
        /// The effective number of transactions.
        /// </summary>
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// The signed adjustment included in the effective count. Only present for drafts.
        /// </summary>
        [JsonProperty("delta")]
        [STJS.JsonPropertyName("delta")]
        public long Delta { get; set; }
    }
}
