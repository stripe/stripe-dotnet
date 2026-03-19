// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AssociationTaxTransactionAttempt : StripeEntity<AssociationTaxTransactionAttempt>
    {
        [JsonProperty("committed")]
        [STJS.JsonPropertyName("committed")]
        public AssociationTaxTransactionAttemptCommitted Committed { get; set; }

        [JsonProperty("errored")]
        [STJS.JsonPropertyName("errored")]
        public AssociationTaxTransactionAttemptErrored Errored { get; set; }

        /// <summary>
        /// The source of the tax transaction attempt. This is either a refund or a payment intent.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// The status of the transaction attempt. This can be <c>errored</c> or <c>committed</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
