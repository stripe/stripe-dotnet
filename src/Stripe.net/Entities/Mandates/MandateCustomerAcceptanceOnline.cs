// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class MandateCustomerAcceptanceOnline : StripeEntity<MandateCustomerAcceptanceOnline>
    {
        /// <summary>
        /// The customer accepts the mandate from this IP address.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The customer accepts the mandate using the user agent of the browser.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
