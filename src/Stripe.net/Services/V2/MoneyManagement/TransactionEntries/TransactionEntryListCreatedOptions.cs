// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionEntryListCreatedOptions : INestedOptions
    {
        /// <summary>
        /// Filter for Transactions created after the specified timestamp.
        /// </summary>
        [JsonProperty("gt")]
        [STJS.JsonPropertyName("gt")]
        public DateTime? Gt { get; set; }

        /// <summary>
        /// Filter for Transactions created at or after the specified timestamp.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public DateTime? Gte { get; set; }

        /// <summary>
        /// Filter for Transactions created before the specified timestamp.
        /// </summary>
        [JsonProperty("lt")]
        [STJS.JsonPropertyName("lt")]
        public DateTime? Lt { get; set; }

        /// <summary>
        /// Filter for Transactions created at or before the specified timestamp.
        /// </summary>
        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        public DateTime? Lte { get; set; }
    }
}
