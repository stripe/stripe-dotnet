// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreAccountPersonUpdatedEventData : StripeEntity<V2CoreAccountPersonUpdatedEventData>
    {
        /// <summary>
        /// The ID of the v2 account.
        /// </summary>
        [JsonProperty("account_id")]
        [STJS.JsonPropertyName("account_id")]
        public string AccountId { get; set; }
    }
}
