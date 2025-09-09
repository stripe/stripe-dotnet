// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A FinancialAddress contains information needed to transfer money to a Financial Account.
    /// A Financial Account can have more than one Financial Address.
    /// </summary>
    public class FinancialAddress : StripeEntity<FinancialAddress>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of a FinancialAddress.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The creation timestamp of the FinancialAddress.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Object indicates the type of credentials that have been allocated and attached to the
        /// FinancialAddress. It contains all necessary banking details with which to perform money
        /// movements with the FinancialAddress. This field is only available for FinancialAddresses
        /// with an active status.
        /// </summary>
        [JsonProperty("credentials")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credentials")]
#endif
        public FinancialAddressCredentials Credentials { get; set; }

        /// <summary>
        /// Open Enum. The currency the FinancialAddress supports.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// A ID of the FinancialAccount this FinancialAddress corresponds to.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Closed Enum. An enum representing the status of the FinancialAddress. This indicates
        /// whether or not the FinancialAddress can be used for any money movement flows.
        /// One of: <c>active</c>, <c>archived</c>, <c>failed</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
