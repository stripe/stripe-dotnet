namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ApplePayDomainCreateOptions : BaseOptions
    {
        /// <summary>
        /// Domain to add as an Apple Pay Domain
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }
    }
}
