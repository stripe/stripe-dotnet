// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions : INestedOptions
    {
        /// <summary>
        /// Name of associated or partner company for the service.
        /// </summary>
        [JsonProperty("affiliate_name")]
        [STJS.JsonPropertyName("affiliate_name")]
        public string AffiliateName { get; set; }

        /// <summary>
        /// Arrival details.
        /// </summary>
        [JsonProperty("arrival")]
        [STJS.JsonPropertyName("arrival")]
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailArrivalOptions Arrival { get; set; }

        /// <summary>
        /// Name of transportation company.
        /// </summary>
        [JsonProperty("carrier_name")]
        [STJS.JsonPropertyName("carrier_name")]
        public string CarrierName { get; set; }

        /// <summary>
        /// Currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Departure details.
        /// </summary>
        [JsonProperty("departure")]
        [STJS.JsonPropertyName("departure")]
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailDepartureOptions Departure { get; set; }

        /// <summary>
        /// List of insurances for this reservation.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// List of passengers that this reservation applies to.
        /// </summary>
        [JsonProperty("passengers")]
        [STJS.JsonPropertyName("passengers")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailPassengerOptions> Passengers { get; set; }

        /// <summary>
        /// Price in cents.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public long? Price { get; set; }

        /// <summary>
        /// Ticket class.
        /// One of: <c>business</c>, <c>economy</c>, <c>first_class</c>, or <c>premium_economy</c>.
        /// </summary>
        [JsonProperty("ticket_class")]
        [STJS.JsonPropertyName("ticket_class")]
        public string TicketClass { get; set; }
    }
}
