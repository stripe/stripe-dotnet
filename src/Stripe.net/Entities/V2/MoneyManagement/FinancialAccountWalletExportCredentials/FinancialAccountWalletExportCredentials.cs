// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Credentials exported from a FinancialAccount wallet export.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountWalletExportCredentials : StripeEntity<FinancialAccountWalletExportCredentials>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// End of the fixed one-hour credentials retrieval window.
        /// </summary>
        [JsonProperty("credentials_available_until")]
        [STJS.JsonPropertyName("credentials_available_until")]
        public DateTime CredentialsAvailableUntil { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Exported wallets and credentials encrypted to the supplied recipient public key.
        /// </summary>
        [JsonProperty("wallets")]
        [STJS.JsonPropertyName("wallets")]
        public List<FinancialAccountWalletExportCredentialsWallet> Wallets { get; set; }
    }
}
