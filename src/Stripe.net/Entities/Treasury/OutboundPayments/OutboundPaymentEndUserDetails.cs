// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentEndUserDetails : StripeEntity<OutboundPaymentEndUserDetails>
    {
        /// <summary>
        /// IP address of the user initiating the OutboundPayment. Set if <c>present</c> is set to
        /// <c>true</c>. IP address collection is required for risk and compliance reasons. This
        /// will be used to help determine if the OutboundPayment is authorized or should be
        /// blocked.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// <c>true</c> if the OutboundPayment creation request is being made on behalf of an end
        /// user by a platform. Otherwise, <c>false</c>.
        /// </summary>
        [JsonProperty("present")]
        public bool Present { get; set; }
    }
}
