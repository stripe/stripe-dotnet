// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeAdjustmentListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter results by the ID of the FinancialAccount associated with the DisputeAdjustment.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Filter results by the ID of the Dispute associated with the DisputeAdjustment.
        /// </summary>
        [JsonProperty("related_dispute")]
        [STJS.JsonPropertyName("related_dispute")]
        public string RelatedDispute { get; set; }
    }
}
