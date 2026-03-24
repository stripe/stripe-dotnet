// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections>
    {
        [JsonProperty("filters")]
        [STJS.JsonPropertyName("filters")]
        public InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters Filters { get; set; }

        /// <summary>
        /// The list of permissions to request. The <c>payment_method</c> permission must be
        /// included.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
        [STJS.JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Data features requested to be retrieved upon account creation.
        /// One of: <c>balances</c>, <c>inferred_balances</c>, <c>ownership</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("prefetch")]
        [STJS.JsonPropertyName("prefetch")]
        public List<string> Prefetch { get; set; }
    }
}
