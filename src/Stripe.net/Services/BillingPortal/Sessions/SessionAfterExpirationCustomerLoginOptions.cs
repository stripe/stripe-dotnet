// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionAfterExpirationCustomerLoginOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp after which the customer can no longer recover this session. Leave
        /// unset to allow recovery without a deadline.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }
    }
}
