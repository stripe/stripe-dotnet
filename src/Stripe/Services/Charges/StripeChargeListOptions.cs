using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRefundListOptions : StripeListOptions
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }

    }
}