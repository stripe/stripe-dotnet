namespace Stripe.BillingPortal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// ID of the Customer object to create the PortalSession for.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The URL to which Stripe should send customers when they click on the link to return to
        /// your website. This field is required if a default return URL has not been configured in
        /// the Dashboard portal settings page.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
