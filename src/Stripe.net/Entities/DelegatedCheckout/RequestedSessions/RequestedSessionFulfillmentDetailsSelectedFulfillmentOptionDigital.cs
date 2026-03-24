// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionDigital : StripeEntity<RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionDigital>
    {
        /// <summary>
        /// The digital option.
        /// </summary>
        [JsonProperty("digital_option")]
        [STJS.JsonPropertyName("digital_option")]
        public string DigitalOption { get; set; }
    }
}
