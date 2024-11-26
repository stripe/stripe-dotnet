// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Controls how funds transferred by the customer are applied to payment intents and
        /// invoices. Valid options are <c>automatic</c>, <c>manual</c>, or <c>merchant_default</c>.
        /// For more information about these reconciliation modes, see <a
        /// href="https://stripe.com/docs/payments/customer-balance/reconciliation">Reconciliation</a>.
        /// One of: <c>automatic</c>, <c>manual</c>, or <c>merchant_default</c>.
        /// </summary>
        [JsonProperty("reconciliation_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reconciliation_mode")]
#endif
        public string ReconciliationMode { get; set; }
    }
}
