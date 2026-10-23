// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RewardProgramCreateOptions : BaseOptions
    {
        /// <summary>
        /// Determines who performs reward money movement after rule evaluation. Only
        /// <c>application</c> is currently supported.
        /// One of: <c>application</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("fulfilled_by")]
        [STJS.JsonPropertyName("fulfilled_by")]
        public string FulfilledBy { get; set; }

        /// <summary>
        /// Display name for the RewardProgram.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
