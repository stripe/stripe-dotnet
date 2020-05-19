namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionPurchaseDetailsLodging : StripeEntity<TransactionPurchaseDetailsLodging>
    {
        [JsonProperty("check_in_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CheckInAt { get; set; }

        [JsonProperty("nights")]
        public long? Nights { get; set; }
    }
}
