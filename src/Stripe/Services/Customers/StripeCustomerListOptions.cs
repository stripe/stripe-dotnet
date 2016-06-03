using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCustomerListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}