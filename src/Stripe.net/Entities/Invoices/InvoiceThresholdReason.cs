namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceThresholdReason : StripeEntity<InvoiceThresholdReason>
    {
        [JsonProperty("amount_gte")]
        public long? AmountGte { get; set; }

        [JsonProperty("item_reasons")]
        public List<InvoiceThresholdReasonItemReason> ItemReasons { get; set; }
    }
}
