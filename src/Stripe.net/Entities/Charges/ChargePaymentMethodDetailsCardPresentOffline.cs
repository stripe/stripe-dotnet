// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardPresentOffline : StripeEntity<ChargePaymentMethodDetailsCardPresentOffline>
    {
        /// <summary>
        /// Time at which the payment was collected while offline.
        /// </summary>
        [JsonProperty("stored_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StoredAt { get; set; }
    }
}
