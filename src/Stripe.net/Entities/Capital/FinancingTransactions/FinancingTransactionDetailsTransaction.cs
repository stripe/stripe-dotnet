// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancingTransactionDetailsTransaction : StripeEntity<FinancingTransactionDetailsTransaction>
    {
        /// <summary>
        /// The linked payment ID.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif
        public string Charge { get; set; }

        /// <summary>
        /// The linked Treasury Financing Transaction ID.
        /// </summary>
        [JsonProperty("treasury_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("treasury_transaction")]
#endif
        public string TreasuryTransaction { get; set; }
    }
}
