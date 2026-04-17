// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataOptions : INestedOptions, IHasSetTracking
    {
        private List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailOptions> busReservationDetails;
        private List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions> eventReservationDetails;
        private List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions> ferryReservationDetails;
        private List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataInsuranceOptions> insurances;
        private List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions> marketplaceSellers;
        private List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailOptions> roundTripReservationDetails;
        private List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions> trainReservationDetails;
        private List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions> vouchers;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Supplementary bus reservation details.
        /// </summary>
        [JsonProperty("bus_reservation_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("bus_reservation_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailOptions> BusReservationDetails
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
        [JsonProperty("event_reservation_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("event_reservation_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions> EventReservationDetails
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
        [JsonProperty("ferry_reservation_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("ferry_reservation_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataFerryReservationDetailOptions> FerryReservationDetails
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
        [JsonProperty("insurances", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("insurances")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataInsuranceOptions> Insurances
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
        [JsonProperty("marketplace_sellers", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("marketplace_sellers")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerOptions> MarketplaceSellers
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
        [JsonProperty("round_trip_reservation_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("round_trip_reservation_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailOptions> RoundTripReservationDetails
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
        [JsonProperty("train_reservation_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("train_reservation_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailOptions> TrainReservationDetails
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
        [JsonProperty("vouchers", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("vouchers")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions> Vouchers
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
