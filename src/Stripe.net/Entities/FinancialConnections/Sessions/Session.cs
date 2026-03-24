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

        /// <summary>
        /// Settings for the Hosted UI mode.
        /// </summary>
        [JsonProperty("hosted")]
        [STJS.JsonPropertyName("hosted")]
        public SessionHosted Hosted { get; set; }

        [JsonProperty("limits")]
        [STJS.JsonPropertyName("limits")]
        public SessionLimits Limits { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("manual_entry")]
        [STJS.JsonPropertyName("manual_entry")]
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
        [STJS.JsonPropertyName("relink_options")]
        public SessionRelinkOptions RelinkOptions { get; set; }

        [JsonProperty("relink_result")]
        [STJS.JsonPropertyName("relink_result")]
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
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public SessionStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The UI mode for this session.
        /// One of: <c>hosted</c>, or <c>modal</c>.
        /// </summary>
        [JsonProperty("ui_mode")]
        [STJS.JsonPropertyName("ui_mode")]
        public string UiMode { get; set; }

        /// <summary>
        /// The hosted URL for this Session. Redirect customers to this URL to take them to the
        /// hosted authentication flow. This value is only present when the Session is active and
        /// the <c>ui_mode</c> is <c>hosted</c>.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
