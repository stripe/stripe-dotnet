namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class LoginLinkCreateOptions : BaseOptions
    {
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
