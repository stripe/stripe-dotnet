// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAddressDebitOptions : BaseOptions
    {
        /// <summary>
        /// Object containing the amount value and currency to debit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The network to use in simulating the funds flow. This will be reflected in the resulting
        /// ReceivedDebit.
        /// One of: <c>ach</c>, <c>bacs</c>, or <c>sepa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// Network-specific details for the simulated debit. Only used for ACH debits; supplied
        /// details must be valid.
        /// </summary>
        [JsonProperty("network_details")]
        [STJS.JsonPropertyName("network_details")]
        public FinancialAddressDebitNetworkDetailsOptions NetworkDetails { get; set; }

        /// <summary>
        /// String explaining funds flow. Use this field to populate the statement descriptor of the
        /// ReceivedDebit created as an eventual result of this simulation.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
