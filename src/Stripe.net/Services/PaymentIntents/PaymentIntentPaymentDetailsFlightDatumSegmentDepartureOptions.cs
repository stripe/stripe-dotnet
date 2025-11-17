// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatumSegmentDepartureOptions : INestedOptions
    {
        /// <summary>
        /// Departure airport IATA code.
        /// </summary>
        [JsonProperty("airport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("airport")]
#endif
        public string Airport { get; set; }

        /// <summary>
        /// Departure city.
        /// </summary>
        [JsonProperty("city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("city")]
#endif
        public string City { get; set; }

        /// <summary>
        /// Departure country.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Departure date/time.
        /// </summary>
        [JsonProperty("departs_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departs_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DepartsAt { get; set; }
    }
}
