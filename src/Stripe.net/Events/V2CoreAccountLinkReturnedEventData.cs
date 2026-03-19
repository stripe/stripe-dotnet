// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2CoreAccountLinkReturnedEventData : StripeEntity<V2CoreAccountLinkReturnedEventData>
    {
        /// <summary>
        /// The ID of the v2 account.
        /// </summary>
        [JsonProperty("account_id")]
        [STJS.JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Configurations on the Account that was onboarded via the account link.
        /// One of: <c>customer</c>, <c>merchant</c>, or <c>recipient</c>.
        /// </summary>
        [JsonProperty("configurations")]
        [STJS.JsonPropertyName("configurations")]
        public List<string> Configurations { get; set; }

        /// <summary>
        /// Open Enum. The use case type of the account link that has been completed.
        /// One of: <c>account_onboarding</c>, or <c>account_update</c>.
        /// </summary>
        [JsonProperty("use_case")]
        [STJS.JsonPropertyName("use_case")]
        public string UseCase { get; set; }
    }
}
