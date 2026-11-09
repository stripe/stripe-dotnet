// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutIntentUpdateScheduleOptionsOptions : INestedOptions
    {
        /// <summary>
        /// The date when the payout should be executed, in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("execute_on")]
        [STJS.JsonPropertyName("execute_on")]
        public string ExecuteOn { get; set; }
    }
}
