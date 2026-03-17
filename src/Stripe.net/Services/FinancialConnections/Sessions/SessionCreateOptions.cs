// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The account holder to link accounts for.
        /// </summary>
        [JsonProperty("account_holder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder")]
#endif
        public SessionAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// Filters to restrict the kinds of accounts to collect.
        /// </summary>
        [JsonProperty("filters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filters")]
#endif
        public SessionFiltersOptions Filters { get; set; }

        /// <summary>
        /// Settings for hosted Sessions. Required if <c>ui_mode</c> is <c>hosted</c>.
        /// </summary>
        [JsonProperty("hosted")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted")]
#endif
        public SessionHostedOptions Hosted { get; set; }

        /// <summary>
        /// Settings for configuring Session-specific limits.
        /// </summary>
        [JsonProperty("limits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("limits")]
#endif
        public SessionLimitsOptions Limits { get; set; }

        /// <summary>
        /// Customize manual entry behavior.
        /// </summary>
        [JsonProperty("manual_entry")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("manual_entry")]
#endif
        public SessionManualEntryOptions ManualEntry { get; set; }

        /// <summary>
        /// List of data features that you would like to request access to.
        ///
        /// Possible values are <c>balances</c>, <c>transactions</c>, <c>ownership</c>, and
        /// <c>payment_method</c>.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("permissions")]
#endif
        public List<string> Permissions { get; set; }

        /// <summary>
        /// List of data features that you would like to retrieve upon account creation.
        /// One of: <c>balances</c>, <c>inferred_balances</c>, <c>ownership</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("prefetch")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prefetch")]
#endif
        public List<string> Prefetch { get; set; }

        /// <summary>
        /// Options for specifying a Session targeted to relinking an authorization.
        /// </summary>
        [JsonProperty("relink_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relink_options")]
#endif
        public SessionRelinkOptionsOptions RelinkOptions { get; set; }

        /// <summary>
        /// For webview integrations only. Upon completing OAuth login in the native browser, the
        /// user will be redirected to this URL to return to your app.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The UI mode of the Session. Defaults to <c>modal</c>.
        /// One of: <c>hosted</c>, or <c>modal</c>.
        /// </summary>
        [JsonProperty("ui_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ui_mode")]
#endif
        public string UiMode { get; set; }
    }
}
