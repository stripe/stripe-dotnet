// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Financial Connections Session is the secure way to programmatically launch the
    /// client-side Stripe.js modal that lets your users link their accounts.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Session : StripeEntity<Session>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account holder for whom accounts are collected in this session.
        /// </summary>
        [JsonProperty("account_holder")]
        [STJS.JsonPropertyName("account_holder")]
        public SessionAccountHolder AccountHolder { get; set; }

        /// <summary>
        /// The accounts that were collected as part of this Session.
        /// </summary>
        [JsonProperty("accounts")]
        [STJS.JsonPropertyName("accounts")]
        public StripeList<Account> Accounts { get; set; }

        /// <summary>
        /// A value that will be passed to the client to launch the authentication flow.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("filters")]
        [STJS.JsonPropertyName("filters")]
        public SessionFilters Filters { get; set; }

        [JsonProperty("limits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("limits")]
#endif
        public SessionLimits Limits { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("manual_entry")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("manual_entry")]
#endif
        public SessionManualEntry ManualEntry { get; set; }

        /// <summary>
        /// Permissions requested for accounts collected during this session.
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

        [JsonProperty("relink_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relink_options")]
#endif
        public SessionRelinkOptions RelinkOptions { get; set; }

        [JsonProperty("relink_result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relink_result")]
#endif
        public SessionRelinkResult RelinkResult { get; set; }

        /// <summary>
        /// For webview integrations only. Upon completing OAuth login in the native browser, the
        /// user will be redirected to this URL to return to your app.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The current state of the session.
        /// One of: <c>cancelled</c>, <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public SessionStatusDetails StatusDetails { get; set; }
    }
}
