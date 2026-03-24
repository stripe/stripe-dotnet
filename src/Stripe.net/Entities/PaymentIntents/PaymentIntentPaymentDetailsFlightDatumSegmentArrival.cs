// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsFlightDatumSegmentArrival : StripeEntity<PaymentIntentPaymentDetailsFlightDatumSegmentArrival>
    {
        /// <summary>
        /// Arrival airport IATA code.
        /// </summary>
        [JsonProperty("airport")]
        [STJS.JsonPropertyName("airport")]
        public string Airport { get; set; }

        /// <summary>
        /// Arrival date and time.
        /// </summary>
        [JsonProperty("arrives_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("arrives_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ArrivesAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Arrival city.
        /// </summary>
        [JsonProperty("city")]
        [STJS.JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Arrival country.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
