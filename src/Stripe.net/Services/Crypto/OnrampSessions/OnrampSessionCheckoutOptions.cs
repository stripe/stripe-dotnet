// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampSessionCheckoutOptions : BaseOptions
    {
        /// <summary>
        /// This hash contains details about the mandate to create.
        /// </summary>
        [JsonProperty("mandate_data")]
        [STJS.JsonPropertyName("mandate_data")]
        public OnrampSessionMandateDataOptions MandateData { get; set; }
    }
}
