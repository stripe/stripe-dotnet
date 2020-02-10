namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceGiropay : StripeEntity<SourceGiropay>
    {
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }
    }
}
