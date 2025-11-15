// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AssociationTaxTransactionAttempt : StripeEntity<AssociationTaxTransactionAttempt>
    {
        [JsonProperty("committed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("committed")]
#endif
        public AssociationTaxTransactionAttemptCommitted Committed { get; set; }

        [JsonProperty("errored")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errored")]
#endif
        public AssociationTaxTransactionAttemptErrored Errored { get; set; }

        /// <summary>
        /// The source of the tax transaction attempt. This is either a refund or a payment intent.
        /// </summary>
        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif
        public string Source { get; set; }

        /// <summary>
        /// The status of the transaction attempt. This can be <c>errored</c> or <c>committed</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
