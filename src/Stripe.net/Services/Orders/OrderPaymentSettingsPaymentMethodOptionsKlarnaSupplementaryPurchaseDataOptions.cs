// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataOptions : INestedOptions
    {
        /// <summary>
        /// Supplementary bus reservation details.
        /// </summary>
        [JsonProperty("bus_reservation_details")]
        [STJS.JsonPropertyName("bus_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailOptions> BusReservationDetails { get; set; }

        /// <summary>
        /// Supplementary event reservation details.
        /// </summary>
        [JsonProperty("event_reservation_details")]
        [STJS.JsonPropertyName("event_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions> EventReservationDetails { get; set; }

        /// <summary>
        /// Supplementary ferry reservation details.
        /// </summary>
        [JsonProperty("ferry_reservation_details")]
        [STJS.JsonPropertyName("ferry_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions> FerryReservationDetails { get; set; }

        /// <summary>
        /// Supplementary insurance details.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Supplementary marketplace seller details.
        /// </summary>
        [JsonProperty("marketplace_sellers")]
        [STJS.JsonPropertyName("marketplace_sellers")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions> MarketplaceSellers { get; set; }

        /// <summary>
        /// Supplementary round trip reservation details.
        /// </summary>
        [JsonProperty("round_trip_reservation_details")]
        [STJS.JsonPropertyName("round_trip_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailOptions> RoundTripReservationDetails { get; set; }

        /// <summary>
        /// Supplementary train reservation details.
        /// </summary>
        [JsonProperty("train_reservation_details")]
        [STJS.JsonPropertyName("train_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions> TrainReservationDetails { get; set; }

        /// <summary>
        /// Voucher details, such as a gift card or discount code.
        /// </summary>
        [JsonProperty("vouchers")]
        [STJS.JsonPropertyName("vouchers")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions> Vouchers { get; set; }
    }
}
