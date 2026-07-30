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
        /// Tokenization is the process Stripe uses to collect sensitive card or bank account
        /// details, or personally identifiable information (PII), directly from your customers in a
        /// secure manner. A token representing this information is returned to your server to use.
        /// Use our <a href="https://docs.stripe.com/payments">recommended payments integrations</a>
        /// to perform this process on the client-side. This guarantees that no sensitive card data
        /// touches your server, and allows your integration to operate in a PCI-compliant way.
        ///
        /// If you can't use client-side tokenization, you can also create tokens using the API with
        /// either your publishable or secret API key. If your integration uses this method, you're
        /// responsible for any PCI compliance that it might require, and you must keep your secret
        /// API key safe. Unlike with client-side tokenization, your customer's information isn't
        /// sent directly to Stripe, so we can't determine how it's handled or stored.
        ///
        /// You can't store or use tokens more than once. To store card or bank account information
        /// for later use, create <a href="https://docs.stripe.com/api#customers">Customer</a>
        /// objects or <a href="https://stripe.com/api#external_accounts">External accounts</a>. <a
        /// href="https://docs.stripe.com/radar">Radar</a>, our integrated solution for automatic
        /// fraud protection, performs best with integrations that use client-side tokenization.
        /// </summary>
        [JsonProperty("bank_account_token")]
        [STJS.JsonPropertyName("bank_account_token")]
        public Token BankAccountToken { get; set; }

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
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
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
