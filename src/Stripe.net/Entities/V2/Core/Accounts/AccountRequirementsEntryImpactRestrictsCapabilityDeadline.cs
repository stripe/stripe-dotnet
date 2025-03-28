// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementsEntryImpactRestrictsCapabilityDeadline : StripeEntity<AccountRequirementsEntryImpactRestrictsCapabilityDeadline>
    {
        /// <summary>
        /// The current status of the requirement's impact.
        /// One of: <c>currently_due</c>, <c>eventually_due</c>, or <c>past_due</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
