// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReceivedDebitMandateListOptions : V2.ListOptions
    {
        /// <summary>
        /// The ID of the FinancialAccount to filter by.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Filter by mandate status.
        /// One of: <c>active</c>, <c>canceled</c>, <c>expired</c>, or <c>pending_cancellation</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("statuses")]
        [STJS.JsonPropertyName("statuses")]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// The type of ReceivedDebitMandate to filter by.
        /// One of: <c>bank_transfer</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
