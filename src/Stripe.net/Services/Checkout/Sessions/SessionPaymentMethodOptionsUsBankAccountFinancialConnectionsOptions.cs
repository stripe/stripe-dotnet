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
        /// <c>balances</c>, <c>payment_method</c>, and <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }
    }
}
