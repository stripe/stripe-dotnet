namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SourceAuBecsDebit : StripeEntity
    {
        [Obsolete("This property is deprecated, Account Number will not be returned from Stripe API.")]
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [Obsolete("This property is deprecated, please use Last4 going forward.")]
        [JsonProperty("last3")]
        public string Last3 { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }
    }
}
