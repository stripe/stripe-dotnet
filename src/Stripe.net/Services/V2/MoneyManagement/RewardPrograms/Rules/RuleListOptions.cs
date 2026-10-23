// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.RewardPrograms
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RuleListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by RewardProgramRule status.
        /// One of: <c>active</c>, or <c>inactive</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
