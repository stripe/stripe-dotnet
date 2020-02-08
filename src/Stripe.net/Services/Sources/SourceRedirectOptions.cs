namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceRedirectOptions : INestedOptions
    {
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
