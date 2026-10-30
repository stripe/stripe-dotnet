// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RewardProgramEnrollmentCreateOptions : BaseOptions
    {
        /// <summary>
        /// The connected account to enroll into this RewardProgram.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Issuing-specific per-enrollment configuration.
        /// </summary>
        [JsonProperty("card_spend")]
        [STJS.JsonPropertyName("card_spend")]
        public RewardProgramEnrollmentCreateCardSpendOptions CardSpend { get; set; }

        /// <summary>
        /// The RewardProgram to enroll into.
        /// </summary>
        [JsonProperty("reward_program")]
        [STJS.JsonPropertyName("reward_program")]
        public string RewardProgram { get; set; }
    }
}
