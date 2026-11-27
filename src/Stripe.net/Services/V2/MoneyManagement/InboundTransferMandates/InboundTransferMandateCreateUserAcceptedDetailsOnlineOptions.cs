// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferMandateCreateUserAcceptedDetailsOnlineOptions : INestedOptions
    {
        /// <summary>
        /// The IP address from which the merchant accepted the mandate. For connected account
        /// requests, you must provide a valid IPv4 or IPv6 address. For direct account requests,
        /// Stripe derives the address from the request when you don't supply it and rejects the
        /// request if it can't obtain one.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The user agent of the browser from which the merchant accepted the mandate. For direct
        /// account requests, derived from the request when not supplied.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
