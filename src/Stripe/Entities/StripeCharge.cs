using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCharge
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int? AmountInCents { get; set; }

        [JsonProperty("amount_refunded")]
        public int? AmountInCentsRefunded { get; set; }

        [JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fee")]
        public int? FeeInCents { get; set; }

        [JsonProperty("paid")]
        public bool? Paid { get; set; }

        [JsonProperty("refunded")]
        public bool? Refunded { get; set; }

        [JsonProperty("livemode")]
        public bool? LiveMode { get; set; }

		[JsonProperty("card")]
        public StripeCard StripeCard { get; set; }

        [JsonProperty("invoice")]
        public string InvoiceId { get; set; }
    }
}