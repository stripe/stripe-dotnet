// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionEntryListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for TransactionEntries created within a specified time range.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public TransactionEntryListCreatedOptions Created { get; set; }

        /// <summary>
        /// Filter for TransactionEntries belonging to a specific Transaction. This filter only
        /// supports filtering by a Transaction ID, which appears in each TransactionEntry's
        /// <c>transaction</c> field.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
