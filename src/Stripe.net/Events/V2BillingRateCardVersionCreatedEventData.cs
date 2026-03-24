// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2BillingRateCardVersionCreatedEventData : StripeEntity<V2BillingRateCardVersionCreatedEventData>
    {
        /// <summary>
        /// The ID of the RateCard that the RateCardVersion belongs to.
        /// </summary>
        [JsonProperty("rate_card_id")]
        [STJS.JsonPropertyName("rate_card_id")]
        public string RateCardId { get; set; }
    }
}
