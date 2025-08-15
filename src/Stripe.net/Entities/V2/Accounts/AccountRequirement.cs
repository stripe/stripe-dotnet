// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirement : StripeEntity<AccountRequirement>
    {
        /// <summary>
        /// Closed Enum. Whether the responsibility is with the integrator to action, or with Stripe
        /// (to review info, to wait for some condition, etc.).
        /// One of: <c>stripe</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("awaiting_action_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("awaiting_action_from")]
#endif
        public string AwaitingActionFrom { get; set; }

        /// <summary>
        /// When the requirement is due.
        /// </summary>
        [JsonProperty("deadline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deadline")]
#endif
        public AccountRequirementDeadline Deadline { get; set; }

        /// <summary>
        /// Open Enum. The unique identifier describing the data to be collected for this
        /// requirement.
        /// One of: <c>legal_entity.addresses.business_registration.city</c>,
        /// <c>legal_entity.addresses.business_registration.country</c>,
        /// <c>legal_entity.addresses.business_registration.line1</c>,
        /// <c>legal_entity.addresses.business_registration.postal_code</c>,
        /// <c>legal_entity.addresses.business_registration.state</c>,
        /// <c>legal_entity.business_type</c>, <c>legal_entity.documents.primary_identification</c>,
        /// <c>legal_entity.name</c>, <c>recipient_config.recipient_verification</c>,
        /// <c>representative.addresses.residential.city</c>,
        /// <c>representative.addresses.residential.country</c>,
        /// <c>representative.addresses.residential.line1</c>,
        /// <c>representative.addresses.residential.postal_code</c>,
        /// <c>representative.addresses.residential.state</c>, <c>representative.dob</c>,
        /// <c>representative.documents.primary_identification</c>,
        /// <c>representative.given_name</c>, or <c>representative.surname</c>.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Communicate remediation steps with users if data previously submitted by user is not
        /// acceptable by Stripe.
        /// </summary>
        [JsonProperty("errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errors")]
#endif
        public List<AccountRequirementError> Errors { get; set; }

        /// <summary>
        /// Consequence of not completing this entry on time and in a Stripe-accepted manner.
        /// </summary>
        [JsonProperty("impact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impact")]
#endif
        public AccountRequirementImpact Impact { get; set; }

        /// <summary>
        /// Open Enum. Why Stripe wants this information.
        /// One of: <c>routine_onboarding</c>, or <c>routine_verification</c>.
        /// </summary>
        [JsonProperty("requested_reasons")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested_reasons")]
#endif
        public List<string> RequestedReasons { get; set; }
    }
}
