// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MandatePaymentMethodDetailsBlik : StripeEntity<MandatePaymentMethodDetailsBlik>
    {
        /// <summary>
        /// Date at which the mandate expires.
        /// </summary>
        [JsonProperty("expires_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAfter { get; set; }

        [JsonProperty("off_session")]
        public MandatePaymentMethodDetailsBlikOffSession OffSession { get; set; }

        /// <summary>
        /// Type of the mandate.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
