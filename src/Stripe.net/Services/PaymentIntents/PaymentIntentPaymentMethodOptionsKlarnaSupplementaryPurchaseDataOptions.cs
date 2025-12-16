// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataOptions : INestedOptions
    {
        /// <summary>
        /// Supplementary bus reservation details.
        /// </summary>
        [JsonProperty("bus_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bus_reservation_details")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailOptions> BusReservationDetails { get; set; }

        /// <summary>
        /// Supplementary event reservation details.
        /// </summary>
        [JsonProperty("event_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_reservation_details")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions> EventReservationDetails { get; set; }

        /// <summary>
        /// Supplementary ferry reservation details.
        /// </summary>
        [JsonProperty("ferry_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ferry_reservation_details")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions> FerryReservationDetails { get; set; }

        /// <summary>
        /// Supplementary insurance details.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Supplementary marketplace seller details.
        /// </summary>
        [JsonProperty("marketplace_sellers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marketplace_sellers")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions> MarketplaceSellers { get; set; }

        /// <summary>
        /// Supplementary round trip reservation details.
        /// </summary>
        [JsonProperty("round_trip_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("round_trip_reservation_details")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailOptions> RoundTripReservationDetails { get; set; }

        /// <summary>
        /// Supplementary train reservation details.
        /// </summary>
        [JsonProperty("train_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("train_reservation_details")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions> TrainReservationDetails { get; set; }

        /// <summary>
        /// Voucher details, such as a gift card or discount code.
        /// </summary>
        [JsonProperty("vouchers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vouchers")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions> Vouchers { get; set; }
    }
}
