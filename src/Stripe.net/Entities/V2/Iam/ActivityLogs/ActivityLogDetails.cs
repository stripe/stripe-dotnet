// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetails : StripeEntity<ActivityLogDetails>
    {
        /// <summary>
        /// Details of an API key action.
        /// </summary>
        [JsonProperty("api_key")]
        [STJS.JsonPropertyName("api_key")]
        public ActivityLogDetailsApiKey ApiKey { get; set; }

        /// <summary>
        /// The action group type of the activity log entry.
        /// One of: <c>api_key</c>, <c>user_invite</c>, or <c>user_roles</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Details of a user invite action.
        /// </summary>
        [JsonProperty("user_invite")]
        [STJS.JsonPropertyName("user_invite")]
        public ActivityLogDetailsUserInvite UserInvite { get; set; }

        /// <summary>
        /// Details of a user role change action.
        /// </summary>
        [JsonProperty("user_roles")]
        [STJS.JsonPropertyName("user_roles")]
        public ActivityLogDetailsUserRoles UserRoles { get; set; }
    }
}
