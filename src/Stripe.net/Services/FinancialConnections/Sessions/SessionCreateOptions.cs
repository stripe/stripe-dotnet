// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The account holder to link accounts for.
        /// </summary>
        [JsonProperty("account_holder")]
        public SessionAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// Filters to restrict the kinds of accounts to collect.
        /// </summary>
        [JsonProperty("filters")]
        public SessionFiltersOptions Filters { get; set; }

        /// <summary>
        /// List of data features that you would like to request access to.
        ///
        /// Possible values are <c>balances</c>, <c>transactions</c>, <c>ownership</c>, and
        /// <c>payment_method</c>.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// List of data features that you would like to retrieve upon account creation.
        /// One of: <c>balances</c>, or <c>ownership</c>.
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
