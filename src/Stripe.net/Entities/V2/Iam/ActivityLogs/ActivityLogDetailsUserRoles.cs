// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserRoles : StripeEntity<ActivityLogDetailsUserRoles>
    {
        /// <summary>
        /// Roles the user has after the change.
        /// </summary>
        [JsonProperty("new_roles")]
        [STJS.JsonPropertyName("new_roles")]
        public List<string> NewRoles { get; set; }

        /// <summary>
        /// Roles the user had before the change.
        /// </summary>
        [JsonProperty("old_roles")]
        [STJS.JsonPropertyName("old_roles")]
        public List<string> OldRoles { get; set; }

        /// <summary>
        /// Email address of the user whose roles were changed.
        /// </summary>
        [JsonProperty("user_email")]
        [STJS.JsonPropertyName("user_email")]
        public string UserEmail { get; set; }
    }
}
