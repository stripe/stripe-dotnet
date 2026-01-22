// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatumDropOff : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumDropOff>
    {
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public Address Address { get; set; }

        /// <summary>
        /// Name of the location.
        /// </summary>
        [JsonProperty("location_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location_name")]
#endif
        public string LocationName { get; set; }

        /// <summary>
        /// Time associated with the location.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Time { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
