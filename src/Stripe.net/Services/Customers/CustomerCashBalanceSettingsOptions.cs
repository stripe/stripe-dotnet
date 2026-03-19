// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerCashBalanceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Controls how funds transferred by the customer are applied to payment intents and
        /// invoices. Valid options are <c>automatic</c>, <c>manual</c>, or <c>merchant_default</c>.
        /// For more information about these reconciliation modes, see <a
        /// href="https://docs.stripe.com/payments/customer-balance/reconciliation">Reconciliation</a>.
        /// One of: <c>automatic</c>, <c>manual</c>, or <c>merchant_default</c>.
        /// </summary>
        [JsonProperty("reconciliation_mode")]
        [STJS.JsonPropertyName("reconciliation_mode")]
        public string ReconciliationMode { get; set; }
    }
}
