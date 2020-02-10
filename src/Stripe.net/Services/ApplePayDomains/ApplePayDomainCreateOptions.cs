namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplePayDomainCreateOptions : BaseOptions
    {
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }
    }
}
