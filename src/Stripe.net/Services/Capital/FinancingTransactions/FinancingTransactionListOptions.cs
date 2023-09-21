// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;

    public class FinancingTransactionListOptions : ListOptions
    {
        /// <summary>
        /// For transactions of type <c>paydown</c> and reason <c>automatic_withholding</c> only,
        /// only returns transactions that were created as a result of this charge.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Returns transactions that were created that apply to this financing offer ID.
        /// </summary>
        [JsonProperty("financing_offer")]
        public string FinancingOffer { get; set; }

        /// <summary>
        /// Only returns transactions that are responsible for reversing this financing transaction
        /// ID.
        /// </summary>
        [JsonProperty("reversed_transaction")]
        public string ReversedTransaction { get; set; }

        /// <summary>
        /// For transactions of type <c>paydown</c> and reason <c>automatic_withholding</c> only,
        /// only returns transactions that were created as a result of this Treasury Transaction.
        /// </summary>
        [JsonProperty("treasury_transaction")]
        public string TreasuryTransaction { get; set; }
    }
}
