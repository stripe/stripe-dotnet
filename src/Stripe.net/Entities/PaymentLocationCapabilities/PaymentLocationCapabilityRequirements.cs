// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLocationCapabilityRequirements : StripeEntity<PaymentLocationCapabilityRequirements>
    {
        /// <summary>
        /// Fields that need to be collected to keep the capability enabled.
        /// </summary>
        [JsonProperty("currently_due")]
        [STJS.JsonPropertyName("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// Description of why the capability is disabled.
        /// One of: <c>account.capability_required</c>, <c>pending.onboarding</c>,
        /// <c>pending.review</c>, <c>rejected.other</c>, <c>rejected.unsupported_business</c>, or
        /// <c>requirements.fields_needed</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
        [STJS.JsonPropertyName("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
        [JsonProperty("errors")]
        [STJS.JsonPropertyName("errors")]
        public List<PaymentLocationCapabilityRequirementsError> Errors { get; set; }
    }
}
