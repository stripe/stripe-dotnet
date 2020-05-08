namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AuthorizationRequestHistory : StripeEntity<AuthorizationRequestHistory>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
