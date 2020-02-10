namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentMandateDataCustomerAcceptanceOnlineOptions : INestedOptions
    {
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
