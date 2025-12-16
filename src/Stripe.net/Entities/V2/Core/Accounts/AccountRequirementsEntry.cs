// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementsEntry : StripeEntity<AccountRequirementsEntry>
    {
        /// <summary>
        /// Indicates whether the platform or Stripe is currently responsible for taking action on
        /// the requirement. Value can be <c>user</c> or <c>stripe</c>.
        /// One of: <c>stripe</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("awaiting_action_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("awaiting_action_from")]
#endif
        public string AwaitingActionFrom { get; set; }

        /// <summary>
        /// Machine-readable string describing the requirement.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Descriptions of why the requirement must be collected, or why the collected information
        /// isn't satisfactory to Stripe.
        /// </summary>
        [JsonProperty("errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errors")]
#endif
        public List<AccountRequirementsEntryError> Errors { get; set; }

        /// <summary>
        /// A hash describing the impact of not collecting the requirement, or Stripe not being able
        /// to verify the collected information.
        /// </summary>
        [JsonProperty("impact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impact")]
#endif
        public AccountRequirementsEntryImpact Impact { get; set; }

        /// <summary>
        /// The soonest point when the account will be impacted by not providing the requirement.
        /// </summary>
        [JsonProperty("minimum_deadline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_deadline")]
#endif
        public AccountRequirementsEntryMinimumDeadline MinimumDeadline { get; set; }

        /// <summary>
        /// A reference to the location of the requirement.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public AccountRequirementsEntryReference Reference { get; set; }

        /// <summary>
        /// A list of reasons why Stripe is collecting the requirement.
        /// </summary>
        [JsonProperty("requested_reasons")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested_reasons")]
#endif
        public List<AccountRequirementsEntryRequestedReason> RequestedReasons { get; set; }
    }
}
