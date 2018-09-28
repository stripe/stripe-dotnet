namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ApplePayDomainCreateOptions : BaseOptions
    {
        /// <summary>
        /// Domain to add as an Apple Pay Domain
        /// </summary>
        [FormProperty("domain_name")]
        public string DomainName { get; set; }
    }
}
