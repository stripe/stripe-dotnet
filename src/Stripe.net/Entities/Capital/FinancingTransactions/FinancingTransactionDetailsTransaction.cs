// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;

    public class FinancingTransactionDetailsTransaction : StripeEntity<FinancingTransactionDetailsTransaction>
    {
        /// <summary>
        /// The linked payment ID.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// The linked Treasury Financing Transaction ID.
        /// </summary>
        [JsonProperty("treasury_transaction")]
        public string TreasuryTransaction { get; set; }
    }
}
