namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeLoginLinkCreateOptions : StripeBaseOptions
    {
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
