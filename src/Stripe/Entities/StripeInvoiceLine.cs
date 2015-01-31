using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceLines : StripePageable
    {
        [JsonProperty("data")]
        public List<StripeInvoiceLineItem> StripeInvoiceItems { get; set; }
    }
}