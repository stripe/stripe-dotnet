using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeApplePayDomainCreateOptions : StripeBaseOptions
    {
        /// <summary>
        /// Domain to add as an Apple Pay Domain
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }
    }
}