// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsEntry : StripeEntity<AccountFutureRequirementsEntry>
    {
        /// <summary>
        /// Indicates whether the platform or Stripe is currently responsible for taking action on
        /// the requirement. Value can be <c>user</c> or <c>stripe</c>.
        /// One of: <c>stripe</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("awaiting_action_from")]
        [STJS.JsonPropertyName("awaiting_action_from")]
        public string AwaitingActionFrom { get; set; }

        /// <summary>
        /// Machine-readable string describing the requirement.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Descriptions of why the requirement must be collected, or why the collected information
        /// isn't satisfactory to Stripe.
        /// </summary>
        [JsonProperty("errors")]
        [STJS.JsonPropertyName("errors")]
        public List<AccountFutureRequirementsEntryError> Errors { get; set; }

        /// <summary>
        /// A hash describing the impact of not collecting the requirement, or Stripe not being able
        /// to verify the collected information.
        /// </summary>
        [JsonProperty("impact")]
        [STJS.JsonPropertyName("impact")]
        public AccountFutureRequirementsEntryImpact Impact { get; set; }

        /// <summary>
        /// The soonest point when the account will be impacted by not providing the requirement.
        /// </summary>
        [JsonProperty("minimum_deadline")]
        [STJS.JsonPropertyName("minimum_deadline")]
        public AccountFutureRequirementsEntryMinimumDeadline MinimumDeadline { get; set; }

        /// <summary>
        /// A reference to the location of the requirement.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public AccountFutureRequirementsEntryReference Reference { get; set; }

        /// <summary>
        /// A list of reasons why Stripe is collecting the requirement.
        /// </summary>
        [JsonProperty("requested_reasons")]
        [STJS.JsonPropertyName("requested_reasons")]
        public List<AccountFutureRequirementsEntryRequestedReason> RequestedReasons { get; set; }
    }
}
