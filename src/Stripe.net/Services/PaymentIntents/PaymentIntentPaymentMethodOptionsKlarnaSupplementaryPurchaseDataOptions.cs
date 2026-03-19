// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataOptions : INestedOptions
    {
        /// <summary>
        /// Supplementary bus reservation details.
        /// </summary>
        [JsonProperty("bus_reservation_details")]
        [STJS.JsonPropertyName("bus_reservation_details")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailOptions> BusReservationDetails { get; set; }

        /// <summary>
        /// Supplementary event reservation details.
        /// </summary>
        [JsonProperty("event_reservation_details")]
        [STJS.JsonPropertyName("event_reservation_details")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions> EventReservationDetails { get; set; }

        /// <summary>
        /// Supplementary ferry reservation details.
        /// </summary>
        [JsonProperty("ferry_reservation_details")]
        [STJS.JsonPropertyName("ferry_reservation_details")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions> FerryReservationDetails { get; set; }

        /// <summary>
        /// Supplementary insurance details.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Supplementary marketplace seller details.
        /// </summary>
        [JsonProperty("marketplace_sellers")]
        [STJS.JsonPropertyName("marketplace_sellers")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions> MarketplaceSellers { get; set; }

        /// <summary>
        /// Supplementary round trip reservation details.
        /// </summary>
        [JsonProperty("round_trip_reservation_details")]
        [STJS.JsonPropertyName("round_trip_reservation_details")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailOptions> RoundTripReservationDetails { get; set; }

        /// <summary>
        /// Supplementary train reservation details.
        /// </summary>
        [JsonProperty("train_reservation_details")]
        [STJS.JsonPropertyName("train_reservation_details")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions> TrainReservationDetails { get; set; }

        /// <summary>
        /// Voucher details, such as a gift card or discount code.
        /// </summary>
        [JsonProperty("vouchers")]
        [STJS.JsonPropertyName("vouchers")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions> Vouchers { get; set; }
    }
}
