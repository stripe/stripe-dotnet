// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsEntryRequestedReason : StripeEntity<AccountFutureRequirementsEntryRequestedReason>
    {
        /// <summary>
        /// Machine-readable description of Stripe's reason for collecting the requirement.
        /// One of: <c>routine_onboarding</c>, or <c>routine_verification</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
