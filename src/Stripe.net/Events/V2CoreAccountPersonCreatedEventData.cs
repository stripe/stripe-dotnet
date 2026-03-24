// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreAccountPersonCreatedEventData : StripeEntity<V2CoreAccountPersonCreatedEventData>
    {
        /// <summary>
        /// The ID of the v2 account.
        /// </summary>
        [JsonProperty("account_id")]
        [STJS.JsonPropertyName("account_id")]
        public string AccountId { get; set; }
    }
}
