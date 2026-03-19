// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Stripe Treasury provides users with a container for money called a FinancialAccount that
    /// is separate from their Payments balance. FinancialAccounts serve as the source and
    /// destination of Treasury’s money movement APIs.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccount : StripeEntity<FinancialAccount>, IHasId, IHasMetadata, IHasObject
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
        /// The array of paths to active Features in the Features hash.
        /// One of: <c>card_issuing</c>, <c>deposit_insurance</c>, <c>financial_addresses.aba</c>,
        /// <c>financial_addresses.aba.forwarding</c>, <c>inbound_transfers.ach</c>,
        /// <c>intra_stripe_flows</c>, <c>outbound_payments.ach</c>,
        /// <c>outbound_payments.us_domestic_wire</c>, <c>outbound_transfers.ach</c>,
        /// <c>outbound_transfers.us_domestic_wire</c>, or <c>remote_deposit_capture</c>.
        /// </summary>
        [JsonProperty("active_features")]
        [STJS.JsonPropertyName("active_features")]
        public List<string> ActiveFeatures { get; set; }

        /// <summary>
        /// Balance information for the FinancialAccount.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public FinancialAccountBalance Balance { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The display name for the FinancialAccount. Use this field to customize the names of the
        /// FinancialAccounts for your connected accounts. Unlike the <c>nickname</c> field,
        /// <c>display_name</c> is not internal metadata and will be exposed to connected accounts.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Encodes whether a FinancialAccount has access to a particular Feature, with a
        /// <c>status</c> enum and associated <c>status_details</c>. Stripe or the platform can
        /// control Features via the requested field.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public FinancialAccountFeatures Features { get; set; }

        /// <summary>
        /// The set of credentials that resolve to a FinancialAccount.
        /// </summary>
        [JsonProperty("financial_addresses")]
        [STJS.JsonPropertyName("financial_addresses")]
        public List<FinancialAccountFinancialAddress> FinancialAddresses { get; set; }

        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The nickname for the FinancialAccount.
        /// </summary>
        [JsonProperty("nickname")]
        [STJS.JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// The array of paths to pending Features in the Features hash.
        /// One of: <c>card_issuing</c>, <c>deposit_insurance</c>, <c>financial_addresses.aba</c>,
        /// <c>financial_addresses.aba.forwarding</c>, <c>inbound_transfers.ach</c>,
        /// <c>intra_stripe_flows</c>, <c>outbound_payments.ach</c>,
        /// <c>outbound_payments.us_domestic_wire</c>, <c>outbound_transfers.ach</c>,
        /// <c>outbound_transfers.us_domestic_wire</c>, or <c>remote_deposit_capture</c>.
        /// </summary>
        [JsonProperty("pending_features")]
        [STJS.JsonPropertyName("pending_features")]
        public List<string> PendingFeatures { get; set; }

        /// <summary>
        /// The set of functionalities that the platform can restrict on the FinancialAccount.
        /// </summary>
        [JsonProperty("platform_restrictions")]
        [STJS.JsonPropertyName("platform_restrictions")]
        public FinancialAccountPlatformRestrictions PlatformRestrictions { get; set; }

        /// <summary>
        /// The array of paths to restricted Features in the Features hash.
        /// One of: <c>card_issuing</c>, <c>deposit_insurance</c>, <c>financial_addresses.aba</c>,
        /// <c>financial_addresses.aba.forwarding</c>, <c>inbound_transfers.ach</c>,
        /// <c>intra_stripe_flows</c>, <c>outbound_payments.ach</c>,
        /// <c>outbound_payments.us_domestic_wire</c>, <c>outbound_transfers.ach</c>,
        /// <c>outbound_transfers.us_domestic_wire</c>, or <c>remote_deposit_capture</c>.
        /// </summary>
        [JsonProperty("restricted_features")]
        [STJS.JsonPropertyName("restricted_features")]
        public List<string> RestrictedFeatures { get; set; }

        /// <summary>
        /// Status of this FinancialAccount.
        /// One of: <c>closed</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public FinancialAccountStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The currencies the FinancialAccount can hold a balance in. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase.
        /// </summary>
        [JsonProperty("supported_currencies")]
        [STJS.JsonPropertyName("supported_currencies")]
        public List<string> SupportedCurrencies { get; set; }
    }
}
