using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeLoginLinkCreateOptions : StripeBaseOptions
    {
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
