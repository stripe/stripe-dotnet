// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPresentmentDetails : StripeEntity<SubscriptionPresentmentDetails>
    {
        /// <summary>
        /// Currency used for customer payments.
        /// </summary>
        [JsonProperty("presentment_currency")]
        [STJS.JsonPropertyName("presentment_currency")]
        public string PresentmentCurrency { get; set; }
    }
}
