// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions : INestedOptions
    {
        /// <summary>
        /// Provide filters for the linked accounts that the customer can select for the payment
        /// method.
        /// </summary>
        [JsonProperty("filters")]
        public SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions Filters { get; set; }

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
