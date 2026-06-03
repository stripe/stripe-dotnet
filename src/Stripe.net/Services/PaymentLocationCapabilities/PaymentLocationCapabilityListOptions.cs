// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLocationCapabilityListOptions : BaseOptions
    {
        /// <summary>
        /// The payment location that the capabilities enable functionality for.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }
    }
}
