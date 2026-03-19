// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailDepartureOptions : INestedOptions
    {
        /// <summary>
        /// Address of the departure location.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailDepartureAddressOptions Address { get; set; }

        /// <summary>
        /// Timestamp of departure.
        /// </summary>
        [JsonProperty("departs_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("departs_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DepartsAt { get; set; }

        /// <summary>
        /// Identifier name or reference for the origin location.
        /// </summary>
        [JsonProperty("departure_location")]
        [STJS.JsonPropertyName("departure_location")]
        public string DepartureLocation { get; set; }
    }
}
