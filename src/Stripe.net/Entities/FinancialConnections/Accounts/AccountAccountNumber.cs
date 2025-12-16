// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountAccountNumber : StripeEntity<AccountAccountNumber>
    {
        /// <summary>
        /// When the account number is expected to expire, if applicable.
        /// </summary>
        [JsonProperty("expected_expiry_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_expiry_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpectedExpiryDate { get; set; }

        /// <summary>
        /// The type of account number associated with the account.
        /// One of: <c>account_number</c>, or <c>tokenized_account_number</c>.
        /// </summary>
        [JsonProperty("identifier_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identifier_type")]
#endif
        public string IdentifierType { get; set; }

        /// <summary>
        /// Whether the account number is currently active and usable for transactions.
        /// One of: <c>deactivated</c>, or <c>transactable</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The payment networks that the account number can be used for.
        /// </summary>
        [JsonProperty("supported_networks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supported_networks")]
#endif
        public List<string> SupportedNetworks { get; set; }
    }
}
