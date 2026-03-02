// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionDigitalOptions : INestedOptions
    {
        /// <summary>
        /// The digital option identifier.
        /// </summary>
        [JsonProperty("digital_option")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("digital_option")]
#endif
        public string DigitalOption { get; set; }
    }
}
