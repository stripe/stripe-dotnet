using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeApplicationFee
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("livemode")]
        public bool? LiveMode { get; set; }

        [JsonProperty("amount")]
        public int AmountInCents { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("user")]
        public string UserId { get; set; }

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("application")]
        public string ApplicationId { get; set; }

        [JsonProperty("charge")]
        public string ChargeId { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefundedInCents { get; set; }
    }
}