// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountAccountNumber : StripeEntity<AccountAccountNumber>
    {
        /// <summary>
        /// When the account number is expected to expire, if applicable.
        /// </summary>
        [JsonProperty("expected_expiry_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expected_expiry_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpectedExpiryDate { get; set; }

        /// <summary>
        /// The type of account number associated with the account.
        /// One of: <c>account_number</c>, or <c>tokenized_account_number</c>.
        /// </summary>
        [JsonProperty("identifier_type")]
        [STJS.JsonPropertyName("identifier_type")]
        public string IdentifierType { get; set; }

        /// <summary>
        /// Whether the account number is currently active and usable for transactions.
        /// One of: <c>deactivated</c>, or <c>transactable</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The payment networks that the account number can be used for.
        /// </summary>
        [JsonProperty("supported_networks")]
        [STJS.JsonPropertyName("supported_networks")]
        public List<string> SupportedNetworks { get; set; }
    }
}
