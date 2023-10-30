// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions : INestedOptions
    {
        /// <summary>
        /// The list of permissions to request. If this parameter is passed, the
        /// <c>payment_method</c> permission must be included. Valid permissions include:
        /// <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, and <c>transactions</c>.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// List of data features that you would like to retrieve upon account creation.
        /// </summary>
        [JsonProperty("prefetch")]
        public List<string> Prefetch { get; set; }
    }
}
