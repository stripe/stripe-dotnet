// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferMandateUserAcceptedDetailsOnline : StripeEntity<InboundTransferMandateUserAcceptedDetailsOnline>
    {
        /// <summary>
        /// The IP address from which the merchant accepted the mandate. For direct account
        /// requests, derived from the request when not supplied; rejected if obtainable from
        /// neither.
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
