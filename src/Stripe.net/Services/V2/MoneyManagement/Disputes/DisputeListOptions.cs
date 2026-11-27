// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter results by the ID of the FinancialAccount associated with the dispute.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Filter results to Disputes with any of the provided statuses.
        /// One of: <c>lost</c>, <c>under_review</c>, or <c>won</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("statuses")]
        [STJS.JsonPropertyName("statuses")]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// Filter results by the ID of the disputed money movement.
        /// </summary>
        [JsonProperty("target")]
        [STJS.JsonPropertyName("target")]
        public string Target { get; set; }
    }
}
