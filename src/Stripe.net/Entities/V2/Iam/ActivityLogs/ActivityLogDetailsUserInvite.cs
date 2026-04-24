// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserInvite : StripeEntity<ActivityLogDetailsUserInvite>
    {
        /// <summary>
        /// Email address of the invited user.
        /// </summary>
        [JsonProperty("invited_user_email")]
        [STJS.JsonPropertyName("invited_user_email")]
        public string InvitedUserEmail { get; set; }

        /// <summary>
        /// Roles assigned to the invited user.
        /// </summary>
        [JsonProperty("roles")]
        [STJS.JsonPropertyName("roles")]
        public List<string> Roles { get; set; }
    }
}
