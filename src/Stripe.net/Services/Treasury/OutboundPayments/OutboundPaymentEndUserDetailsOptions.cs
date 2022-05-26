// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentEndUserDetailsOptions : INestedOptions
    {
        /// <summary>
        /// IP address of the user initiating the OutboundPayment. Must be supplied if
        /// <c>present</c> is set to <c>true</c>.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// <c>True</c> if the OutboundPayment creation request is being made on behalf of an end
        /// user by a platform. Otherwise, <c>false</c>.
        /// </summary>
        [JsonProperty("present")]
        public bool? Present { get; set; }
    }
}
