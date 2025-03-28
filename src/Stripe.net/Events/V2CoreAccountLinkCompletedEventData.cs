// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreAccountLinkCompletedEventData : StripeEntity<V2CoreAccountLinkCompletedEventData>
    {
        /// <summary>
        /// The ID of the v2 account.
        /// </summary>
        [JsonProperty("account_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_id")]
#endif
        public string AccountId { get; set; }

        /// <summary>
        /// Configurations on the Account that was onboarded via the account link.
        /// </summary>
        [JsonProperty("configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configurations")]
#endif
        public List<string> Configurations { get; set; }

        /// <summary>
        /// Open Enum. The use case type of the account link that has been completed.
        /// One of: <c>account_onboarding</c>, or <c>account_update</c>.
        /// </summary>
        [JsonProperty("use_case")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_case")]
#endif
        public string UseCase { get; set; }
    }
}
