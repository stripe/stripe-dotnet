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
        /// Set of filters to query TransactionEntries within a range of <c>created</c> timestamps.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public TransactionEntryListCreatedOptions Created { get; set; }

        /// <summary>
        /// Filter for TransactionEntries belonging to a Transaction.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
