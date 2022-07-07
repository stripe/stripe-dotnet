// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CashBalanceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Controls how funds transferred by the customer are applied to payment intents and
        /// invoices. Valid options are <c>automatic</c> or <c>manual</c>. For more information
        /// about these reconciliation modes, see <a
        /// href="https://stripe.com/docs/payments/customer-balance/reconciliation">Reconciliation</a>.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("reconciliation_mode")]
        public string ReconciliationMode { get; set; }
    }
}
