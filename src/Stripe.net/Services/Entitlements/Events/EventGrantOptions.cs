// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EventGrantOptions : INestedOptions
    {
        /// <summary>
        /// When manually creating a grant entitlement event, you can make it a temporary grant by
        /// setting it to expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }
    }
}
