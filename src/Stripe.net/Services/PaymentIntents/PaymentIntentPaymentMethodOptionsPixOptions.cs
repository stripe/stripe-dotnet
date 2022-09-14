// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsPixOptions : INestedOptions
    {
        /// <summary>
        /// The number of seconds (between 10 and 1209600) after which Pix payment will expire.
        /// Defaults to 86400 seconds.
        /// </summary>
        [JsonProperty("expires_after_seconds")]
        public long? ExpiresAfterSeconds { get; set; }

        /// <summary>
        /// The timestamp at which the Pix expires (between 10 and 1209600 seconds in the future).
        /// Defaults to 1 day in the future.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }
    }
}
