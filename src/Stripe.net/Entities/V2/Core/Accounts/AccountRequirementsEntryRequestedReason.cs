// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementsEntryRequestedReason : StripeEntity<AccountRequirementsEntryRequestedReason>
    {
        /// <summary>
        /// Machine-readable description of Stripe's reason for collecting the requirement.
        /// One of: <c>future_requirements</c>, <c>routine_onboarding</c>, or
        /// <c>routine_verification</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }
    }
}
