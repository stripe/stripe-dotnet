namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class RequestHistory : StripeEntity
    {
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("authorized_amount")]
        public long AuthorizedAmount { get; set; }

        [JsonProperty("authorized_currency")]
        public string AuthorizedCurrency { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("held_amount")]
        public long HeldAmount { get; set; }

        [JsonProperty("held_currency")]
        public string HeldCurrency { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
