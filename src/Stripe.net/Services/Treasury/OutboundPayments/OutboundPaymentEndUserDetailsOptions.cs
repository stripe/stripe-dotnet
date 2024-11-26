// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentEndUserDetailsOptions : INestedOptions
    {
        /// <summary>
        /// IP address of the user initiating the OutboundPayment. Must be supplied if
        /// <c>present</c> is set to <c>true</c>.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif
        public string IpAddress { get; set; }

        /// <summary>
        /// <c>True</c> if the OutboundPayment creation request is being made on behalf of an end
        /// user by a platform. Otherwise, <c>false</c>.
        /// </summary>
        [JsonProperty("present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("present")]
#endif
        public bool? Present { get; set; }
    }
}
