// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataOptions : INestedOptions, IHasSetTracking
    {
        private List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailOptions> busReservationDetails;
        private List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions> eventReservationDetails;
        private List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions> ferryReservationDetails;
        private List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataInsuranceOptions> insurances;
        private List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions> marketplaceSellers;
        private List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailOptions> roundTripReservationDetails;
        private List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions> trainReservationDetails;
        private List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions> vouchers;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Supplementary bus reservation details.
        /// </summary>
        [JsonProperty("bus_reservation_details")]
        [STJS.JsonPropertyName("bus_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailOptions> BusReservationDetails
        {
            get => this.busReservationDetails;
            set
            {
                this.busReservationDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Supplementary event reservation details.
        /// </summary>
        [JsonProperty("event_reservation_details")]
        [STJS.JsonPropertyName("event_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions> EventReservationDetails
        {
            get => this.eventReservationDetails;
            set
            {
                this.eventReservationDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Supplementary ferry reservation details.
        /// </summary>
        [JsonProperty("ferry_reservation_details")]
        [STJS.JsonPropertyName("ferry_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions> FerryReservationDetails
        {
            get => this.ferryReservationDetails;
            set
            {
                this.ferryReservationDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Supplementary insurance details.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataInsuranceOptions> Insurances
        {
            get => this.insurances;
            set
            {
                this.insurances = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Supplementary marketplace seller details.
        /// </summary>
        [JsonProperty("marketplace_sellers")]
        [STJS.JsonPropertyName("marketplace_sellers")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions> MarketplaceSellers
        {
            get => this.marketplaceSellers;
            set
            {
                this.marketplaceSellers = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Supplementary round trip reservation details.
        /// </summary>
        [JsonProperty("round_trip_reservation_details")]
        [STJS.JsonPropertyName("round_trip_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailOptions> RoundTripReservationDetails
        {
            get => this.roundTripReservationDetails;
            set
            {
                this.roundTripReservationDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Supplementary train reservation details.
        /// </summary>
        [JsonProperty("train_reservation_details")]
        [STJS.JsonPropertyName("train_reservation_details")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions> TrainReservationDetails
        {
            get => this.trainReservationDetails;
            set
            {
                this.trainReservationDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Voucher details, such as a gift card or discount code.
        /// </summary>
        [JsonProperty("vouchers")]
        [STJS.JsonPropertyName("vouchers")]
        public List<OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions> Vouchers
        {
            get => this.vouchers;
            set
            {
                this.vouchers = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
