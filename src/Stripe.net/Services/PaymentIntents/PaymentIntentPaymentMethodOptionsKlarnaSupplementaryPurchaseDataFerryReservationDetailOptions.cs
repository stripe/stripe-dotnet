// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions : INestedOptions
    {
        /// <summary>
        /// Name of associated or partner company for the service.
        /// </summary>
        [JsonProperty("affiliate_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate_name")]
#endif
        public string AffiliateName { get; set; }

        /// <summary>
        /// Arrival details.
        /// </summary>
        [JsonProperty("arrival")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrival")]
#endif
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailArrivalOptions Arrival { get; set; }

        /// <summary>
        /// Name of transportation company.
        /// </summary>
        [JsonProperty("carrier_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier_name")]
#endif
        public string CarrierName { get; set; }

        /// <summary>
        /// Currency.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Departure details.
        /// </summary>
        [JsonProperty("departure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departure")]
#endif
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailDepartureOptions Departure { get; set; }

        /// <summary>
        /// List of insurances for this reservation.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// List of passengers that this reservation applies to.
        /// </summary>
        [JsonProperty("passengers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passengers")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailPassengerOptions> Passengers { get; set; }

        /// <summary>
        /// Price in cents.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public long? Price { get; set; }

        /// <summary>
        /// Ticket class.
        /// One of: <c>business</c>, <c>economy</c>, <c>first_class</c>, or <c>premium_economy</c>.
        /// </summary>
        [JsonProperty("ticket_class")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ticket_class")]
#endif
        public string TicketClass { get; set; }
    }
}
