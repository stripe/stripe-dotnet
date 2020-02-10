namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceReceiverOptions : INestedOptions
    {
        [JsonProperty("refund_attributes_method")]
        public string RefundAttributesMethod { get; set; }
    }
}
