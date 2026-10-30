// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RewardProgramEnrollmentListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by RewardProgram. Omitting this field returns platform-wide enrollments across
        /// all RewardPrograms.
        /// </summary>
        [JsonProperty("reward_program")]
        [STJS.JsonPropertyName("reward_program")]
        public string RewardProgram { get; set; }

        /// <summary>
        /// Filter by RewardProgramEnrollment status.
        /// One of: <c>active</c>, or <c>inactive</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
