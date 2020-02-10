namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplePayDomainListOptions : ListOptions
    {
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }
    }
}
