namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentMandateDataCustomerAcceptanceOnlineOptions : INestedOptions
    {
        /// <summary>
        /// The IP address from which the Mandate was accepted by the customer.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The user agent of the browser from which the Mandate was accepted by the customer.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
