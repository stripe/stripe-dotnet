// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataOptions : INestedOptions
    {
        /// <summary>
        /// Supplementary bus reservation details.
        /// </summary>
        [JsonProperty("bus_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bus_reservation_details")]
#endif
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailOptions> BusReservationDetails { get; set; }

        /// <summary>
        /// Supplementary event reservation details.
        /// </summary>
        [JsonProperty("event_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_reservation_details")]
#endif
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions> EventReservationDetails { get; set; }

        /// <summary>
        /// Supplementary ferry reservation details.
        /// </summary>
        [JsonProperty("ferry_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ferry_reservation_details")]
#endif
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions> FerryReservationDetails { get; set; }

        /// <summary>
        /// Supplementary insurance details.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Supplementary marketplace seller details.
        /// </summary>
        [JsonProperty("marketplace_sellers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marketplace_sellers")]
#endif
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions> MarketplaceSellers { get; set; }

        /// <summary>
        /// Supplementary round trip reservation details.
        /// </summary>
        [JsonProperty("round_trip_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("round_trip_reservation_details")]
#endif
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailOptions> RoundTripReservationDetails { get; set; }

        /// <summary>
        /// Supplementary train reservation details.
        /// </summary>
        [JsonProperty("train_reservation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("train_reservation_details")]
#endif
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions> TrainReservationDetails { get; set; }

        /// <summary>
        /// Voucher details, such as a gift card or discount code.
        /// </summary>
        [JsonProperty("vouchers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vouchers")]
#endif
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions> Vouchers { get; set; }
    }
}
