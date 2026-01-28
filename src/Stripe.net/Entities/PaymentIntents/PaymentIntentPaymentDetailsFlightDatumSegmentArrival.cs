// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatumSegmentArrival : StripeEntity<PaymentIntentPaymentDetailsFlightDatumSegmentArrival>
    {
        /// <summary>
        /// Arrival airport IATA code.
        /// </summary>
        [JsonProperty("airport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("airport")]
#endif
        public string Airport { get; set; }

        /// <summary>
        /// Arrival date and time.
        /// </summary>
        [JsonProperty("arrives_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrives_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ArrivesAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Arrival city.
        /// </summary>
        [JsonProperty("city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("city")]
#endif
        public string City { get; set; }

        /// <summary>
        /// Arrival country.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }
    }
}
