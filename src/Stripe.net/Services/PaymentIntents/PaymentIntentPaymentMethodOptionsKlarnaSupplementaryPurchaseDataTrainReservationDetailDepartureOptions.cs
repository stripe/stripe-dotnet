// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailDepartureOptions : INestedOptions
    {
        /// <summary>
        /// Address of the departure location.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailDepartureAddressOptions Address { get; set; }

        /// <summary>
        /// Timestamp of departure.
        /// </summary>
        [JsonProperty("departs_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departs_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DepartsAt { get; set; }

        /// <summary>
        /// Identifier name or reference for the origin location.
        /// </summary>
        [JsonProperty("departure_location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departure_location")]
#endif
        public string DepartureLocation { get; set; }
    }
}
