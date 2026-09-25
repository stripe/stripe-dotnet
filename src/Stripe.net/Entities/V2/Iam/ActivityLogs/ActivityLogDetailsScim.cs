// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsScim : StripeEntity<ActivityLogDetailsScim>
    {
        /// <summary>
        /// Name of the SCIM group.
        /// </summary>
        [JsonProperty("group_name")]
        [STJS.JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// Group roles after the change; only set for the group roles-updated action
        /// (scim_group_roles_updated).
        /// </summary>
        [JsonProperty("new_roles")]
        [STJS.JsonPropertyName("new_roles")]
        public List<string> NewRoles { get; set; }

        /// <summary>
        /// Group roles before the change; only set for the group roles-updated action
        /// (scim_group_roles_updated).
        /// </summary>
        [JsonProperty("old_roles")]
        [STJS.JsonPropertyName("old_roles")]
        public List<string> OldRoles { get; set; }

        /// <summary>
        /// The context the roles were assigned in.
        /// </summary>
        [JsonProperty("role_assigned_context")]
        [STJS.JsonPropertyName("role_assigned_context")]
        public string RoleAssignedContext { get; set; }

        /// <summary>
        /// Email address of the affected member.
        /// </summary>
        [JsonProperty("user_email")]
        [STJS.JsonPropertyName("user_email")]
        public string UserEmail { get; set; }
    }
}
