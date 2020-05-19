namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentIntentMandateDataCustomerAcceptanceOnlineOptions : INestedOptions
    {
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
