// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsOptions : INestedOptions, IHasSetTracking
    {
        private List<PaymentIntentPaymentDetailsCarRentalDatumOptions> carRentalData;
        private string customerReference;
        private List<PaymentIntentPaymentDetailsFleetDatumOptions> fleetData;
        private List<PaymentIntentPaymentDetailsFlightDatumOptions> flightData;
        private List<PaymentIntentPaymentDetailsLodgingDatumOptions> lodgingData;
        private PaymentIntentPaymentDetailsMoneyServicesOptions moneyServices;
        private string orderReference;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Benefit details for this PaymentIntent.
        /// </summary>
        [JsonProperty("benefit")]
        [STJS.JsonPropertyName("benefit")]
        public PaymentIntentPaymentDetailsBenefitOptions Benefit { get; set; }

        /// <summary>
        /// Car rental details for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental")]
        [STJS.JsonPropertyName("car_rental")]
        public PaymentIntentPaymentDetailsCarRentalOptions CarRental { get; set; }

        /// <summary>
        /// Car rental data for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental_data")]
        [STJS.JsonPropertyName("car_rental_data")]
        public List<PaymentIntentPaymentDetailsCarRentalDatumOptions> CarRentalData
        {
            get => this.carRentalData;
            set
            {
                this.carRentalData = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A unique value to identify the customer. This field is available only for card payments.
        ///
        /// This field is truncated to 25 alphanumeric characters, excluding spaces, before being
        /// sent to card networks.
        /// </summary>
        [JsonProperty("customer_reference")]
        [STJS.JsonPropertyName("customer_reference")]
        public string CustomerReference
        {
            get => this.customerReference;
            set
            {
                this.customerReference = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Event details for this PaymentIntent.
        /// </summary>
        [JsonProperty("event_details")]
        [STJS.JsonPropertyName("event_details")]
        public PaymentIntentPaymentDetailsEventDetailsOptions EventDetails { get; set; }

        /// <summary>
        /// Fleet data for this PaymentIntent.
        /// </summary>
        [JsonProperty("fleet_data")]
        [STJS.JsonPropertyName("fleet_data")]
        public List<PaymentIntentPaymentDetailsFleetDatumOptions> FleetData
        {
            get => this.fleetData;
            set
            {
                this.fleetData = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Flight reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("flight")]
        [STJS.JsonPropertyName("flight")]
        public PaymentIntentPaymentDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Flight data for this PaymentIntent.
        /// </summary>
        [JsonProperty("flight_data")]
        [STJS.JsonPropertyName("flight_data")]
        public List<PaymentIntentPaymentDetailsFlightDatumOptions> FlightData
        {
            get => this.flightData;
            set
            {
                this.flightData = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Lodging reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("lodging")]
        [STJS.JsonPropertyName("lodging")]
        public PaymentIntentPaymentDetailsLodgingOptions Lodging { get; set; }

        /// <summary>
        /// Lodging data for this PaymentIntent.
        /// </summary>
        [JsonProperty("lodging_data")]
        [STJS.JsonPropertyName("lodging_data")]
        public List<PaymentIntentPaymentDetailsLodgingDatumOptions> LodgingData
        {
            get => this.lodgingData;
            set
            {
                this.lodgingData = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Money services details for this PaymentIntent.
        /// </summary>
        [JsonProperty("money_services")]
        [STJS.JsonPropertyName("money_services")]
        public PaymentIntentPaymentDetailsMoneyServicesOptions MoneyServices
        {
            get => this.moneyServices;
            set
            {
                this.moneyServices = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A unique value assigned by the business to identify the transaction. Required for L2 and
        /// L3 rates.
        ///
        /// For Cards, this field is truncated to 25 alphanumeric characters, excluding spaces,
        /// before being sent to card networks. For Klarna, this field is truncated to 255
        /// characters and is visible to customers when they view the order in the Klarna app.
        /// </summary>
        [JsonProperty("order_reference")]
        [STJS.JsonPropertyName("order_reference")]
        public string OrderReference
        {
            get => this.orderReference;
            set
            {
                this.orderReference = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Subscription details for this PaymentIntent.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public PaymentIntentPaymentDetailsSubscriptionOptions Subscription { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
