// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUs1099KPaymentTransactionsCountOptions : INestedOptions
    {
        /// <summary>
        /// The replacement non-negative transaction count.
        /// </summary>
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public long? Count { get; set; }
    }
}
