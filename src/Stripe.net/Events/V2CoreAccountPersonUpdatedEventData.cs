// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreAccountPersonUpdatedEventData : StripeEntity<V2CoreAccountPersonUpdatedEventData>
    {
        /// <summary>
        /// The ID of the v2 account.
        /// </summary>
        [JsonProperty("account_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_id")]
#endif
        public string AccountId { get; set; }
    }
}
