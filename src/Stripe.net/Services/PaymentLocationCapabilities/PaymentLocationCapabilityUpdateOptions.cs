// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLocationCapabilityUpdateOptions : BaseOptions
    {
        /// <summary>
        /// The location that the capability enables functionality for.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// To request a new capability for the location, set this to <c>true</c>. You can remove it
        /// from the location by passing <c>false</c>.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool? Requested { get; set; }
    }
}
