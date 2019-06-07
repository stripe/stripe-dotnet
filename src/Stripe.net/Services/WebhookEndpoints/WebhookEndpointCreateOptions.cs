namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class WebhookEndpointCreateOptions : WebhookEndpointSharedOptions
    {
        /// <summary>
        /// Events sent to this endpoint will be generated with this API version instead of your
        /// account's default API version. We recommend that you set this to the API version that
        /// the library is pinned to in <see cref="StripeConfiguration.ApiVersion"/>.
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Whether this endpoint should receive events from connected accounts or your account.
        /// </summary>
        [JsonProperty("connect")]
        public bool? Connect { get; set; }
    }
}
