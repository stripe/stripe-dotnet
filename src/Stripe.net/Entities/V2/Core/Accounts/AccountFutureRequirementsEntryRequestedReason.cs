// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountFutureRequirementsEntryRequestedReason : StripeEntity<AccountFutureRequirementsEntryRequestedReason>
    {
        /// <summary>
        /// Machine-readable description of Stripe's reason for collecting the requirement.
        /// One of: <c>routine_onboarding</c>, or <c>routine_verification</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }
    }
}
