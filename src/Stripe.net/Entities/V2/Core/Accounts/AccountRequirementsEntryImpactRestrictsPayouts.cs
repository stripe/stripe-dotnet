// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementsEntryImpactRestrictsPayouts : StripeEntity<AccountRequirementsEntryImpactRestrictsPayouts>
    {
        /// <summary>
        /// Details about when in the Account's lifecycle the requirement must be collected by the
        /// avoid the earliest specified impact.
        /// </summary>
        [JsonProperty("deadline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deadline")]
#endif
        public AccountRequirementsEntryImpactRestrictsPayoutsDeadline Deadline { get; set; }
    }
}
