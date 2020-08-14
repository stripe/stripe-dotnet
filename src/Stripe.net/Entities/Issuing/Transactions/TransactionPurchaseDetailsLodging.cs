namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionPurchaseDetailsLodging : StripeEntity<TransactionPurchaseDetailsLodging>
    {
        [JsonProperty("check_in_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CheckInAt { get; set; }

        [JsonProperty("nights")]
        public long? Nights { get; set; }
    }
}
