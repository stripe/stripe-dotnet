namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountTosAcceptance : StripeEntity<AccountTosAcceptance>
    {
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Date { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
