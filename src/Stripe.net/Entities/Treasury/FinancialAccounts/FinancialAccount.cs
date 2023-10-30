// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Stripe Treasury provides users with a container for money called a FinancialAccount that
    /// is separate from their Payments balance. FinancialAccounts serve as the source and
    /// destination of Treasury’s money movement APIs.
    /// </summary>
    public class FinancialAccount : StripeEntity<FinancialAccount>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The array of paths to active Features in the Features hash.
        /// One of: <c>card_issuing</c>, <c>deposit_insurance</c>, <c>financial_addresses.aba</c>,
        /// <c>inbound_transfers.ach</c>, <c>intra_stripe_flows</c>, <c>outbound_payments.ach</c>,
        /// <c>outbound_payments.us_domestic_wire</c>, <c>outbound_transfers.ach</c>,
        /// <c>outbound_transfers.us_domestic_wire</c>, or <c>remote_deposit_capture</c>.
        /// </summary>
        [JsonProperty("active_features")]
        public List<string> ActiveFeatures { get; set; }

        /// <summary>
        /// Balance information for the FinancialAccount.
        /// </summary>
        [JsonProperty("balance")]
        public FinancialAccountBalance Balance { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Encodes whether a FinancialAccount has access to a particular Feature, with a
        /// <c>status</c> enum and associated <c>status_details</c>. Stripe or the platform can
        /// control Features via the requested field.
        /// </summary>
        [JsonProperty("features")]
        public FinancialAccountFeatures Features { get; set; }

        /// <summary>
        /// The set of credentials that resolve to a FinancialAccount.
        /// </summary>
        [JsonProperty("financial_addresses")]
        public List<FinancialAccountFinancialAddress> FinancialAddresses { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The array of paths to pending Features in the Features hash.
        /// One of: <c>card_issuing</c>, <c>deposit_insurance</c>, <c>financial_addresses.aba</c>,
        /// <c>inbound_transfers.ach</c>, <c>intra_stripe_flows</c>, <c>outbound_payments.ach</c>,
        /// <c>outbound_payments.us_domestic_wire</c>, <c>outbound_transfers.ach</c>,
        /// <c>outbound_transfers.us_domestic_wire</c>, or <c>remote_deposit_capture</c>.
        /// </summary>
        [JsonProperty("pending_features")]
        public List<string> PendingFeatures { get; set; }

        /// <summary>
        /// The set of functionalities that the platform can restrict on the FinancialAccount.
        /// </summary>
        [JsonProperty("platform_restrictions")]
        public FinancialAccountPlatformRestrictions PlatformRestrictions { get; set; }

        /// <summary>
        /// The array of paths to restricted Features in the Features hash.
        /// One of: <c>card_issuing</c>, <c>deposit_insurance</c>, <c>financial_addresses.aba</c>,
        /// <c>inbound_transfers.ach</c>, <c>intra_stripe_flows</c>, <c>outbound_payments.ach</c>,
        /// <c>outbound_payments.us_domestic_wire</c>, <c>outbound_transfers.ach</c>,
        /// <c>outbound_transfers.us_domestic_wire</c>, or <c>remote_deposit_capture</c>.
        /// </summary>
        [JsonProperty("restricted_features")]
        public List<string> RestrictedFeatures { get; set; }

        /// <summary>
        /// The enum specifying what state the account is in.
        /// One of: <c>closed</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_details")]
        public FinancialAccountStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The currencies the FinancialAccount can hold a balance in. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase.
        /// </summary>
        [JsonProperty("supported_currencies")]
        public List<string> SupportedCurrencies { get; set; }
    }
}
