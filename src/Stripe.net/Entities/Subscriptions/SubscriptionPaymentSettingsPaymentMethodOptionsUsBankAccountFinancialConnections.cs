// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections>
    {
        [JsonProperty("filters")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters Filters { get; set; }

        /// <summary>
        /// The list of permissions to request. The <c>payment_method</c> permission must be
        /// included.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Data features requested to be retrieved upon account creation.
        /// One of: <c>balances</c>, <c>inferred_balances</c>, <c>ownership</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("prefetch")]
        public List<string> Prefetch { get; set; }
    }
}
