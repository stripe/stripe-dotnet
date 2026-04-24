// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ActivityLogListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter results to only include activity logs for the specified action group types.
        /// One of: <c>api_key</c>, <c>user_invite</c>, or <c>user_roles</c>.
        /// </summary>
        [JsonProperty("action_groups")]
        [STJS.JsonPropertyName("action_groups")]
        public List<string> ActionGroups { get; set; }

        /// <summary>
        /// Filter results to only include activity logs for the specified action types.
        /// One of: <c>api_key_created</c>, <c>api_key_deleted</c>, <c>api_key_updated</c>,
        /// <c>api_key_viewed</c>, <c>user_invite_accepted</c>, <c>user_invite_created</c>,
        /// <c>user_invite_deleted</c>, <c>user_roles_deleted</c>, or <c>user_roles_updated</c>.
        /// </summary>
        [JsonProperty("actions")]
        [STJS.JsonPropertyName("actions")]
        public List<string> Actions { get; set; }
    }
}
