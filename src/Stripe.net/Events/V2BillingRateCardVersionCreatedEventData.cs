// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2BillingRateCardVersionCreatedEventData : StripeEntity<V2BillingRateCardVersionCreatedEventData>
    {
        /// <summary>
        /// The ID of the RateCard that the RateCardVersion belongs to.
        /// </summary>
        [JsonProperty("rate_card_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_id")]
#endif
        public string RateCardId { get; set; }
    }
}
