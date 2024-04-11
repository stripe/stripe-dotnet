// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsUsBankAccountFinancialConnections : StripeEntity<SessionPaymentMethodOptionsUsBankAccountFinancialConnections>
    {
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
        /// One of: <c>balances</c>, <c>ownership</c>, or <c>transactions</c>.
        /// </summary>
        [JsonProperty("prefetch")]
        public List<string> Prefetch { get; set; }

        /// <summary>
        /// For webview integrations only. Upon completing OAuth login in the native browser, the
        /// user will be redirected to this URL to return to your app.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
