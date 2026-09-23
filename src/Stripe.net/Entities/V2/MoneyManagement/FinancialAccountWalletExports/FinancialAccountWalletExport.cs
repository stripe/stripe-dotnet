// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The singleton wallet export for a FinancialAccount.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountWalletExport : StripeEntity<FinancialAccountWalletExport>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// End of the fixed one-hour credentials retrieval window. Null until the first successful
        /// credential export; remains readable after expiry.
        /// </summary>
        [JsonProperty("credentials_available_until")]
        [STJS.JsonPropertyName("credentials_available_until")]
        public DateTime? CredentialsAvailableUntil { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// FinancialAccount whose wallet is being exported.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Current wallet export status. The lifecycle is pending, ready, then complete.
        /// One of: <c>complete</c>, <c>pending</c>, or <c>ready</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Public wallet metadata. Null while pending or ready, and retained after the credential
        /// window expires.
        /// </summary>
        [JsonProperty("wallets")]
        [STJS.JsonPropertyName("wallets")]
        public List<FinancialAccountWalletExportWallet> Wallets { get; set; }
    }
}
