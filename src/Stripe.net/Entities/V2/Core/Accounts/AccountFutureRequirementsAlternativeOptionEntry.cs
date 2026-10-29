// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsAlternativeOptionEntry : StripeEntity<AccountFutureRequirementsAlternativeOptionEntry>
    {
        /// <summary>
        /// Indicates whether the user or Stripe is currently responsible for taking action on the
        /// requirement. Value can be <c>user</c> or <c>stripe</c>.
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
        public List<AccountFutureRequirementsAlternativeOptionEntryError> Errors { get; set; }

        /// <summary>
        /// A reference to the location of the requirement.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public AccountFutureRequirementsAlternativeOptionEntryReference Reference { get; set; }
    }
}
