// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsOptions : INestedOptions, IHasSetTracking
    {
        private List<ChargePaymentDetailsCarRentalDatumOptions> carRentalData;
        private string customerReference;
        private List<ChargePaymentDetailsFleetDatumOptions> fleetData;
        private List<ChargePaymentDetailsFlightDatumOptions> flightData;
        private List<ChargePaymentDetailsLodgingDatumOptions> lodgingData;
        private ChargePaymentDetailsMoneyServicesOptions moneyServices;
        private string orderReference;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Car rental details for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental")]
        [STJS.JsonPropertyName("car_rental")]
        public ChargePaymentDetailsCarRentalOptions CarRental { get; set; }

        /// <summary>
        /// Car rental data for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("car_rental_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<ChargePaymentDetailsCarRentalDatumOptions> CarRentalData
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
        [JsonProperty("customer_reference", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_reference")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        public ChargePaymentDetailsEventDetailsOptions EventDetails { get; set; }

        /// <summary>
        /// Fleet data for this PaymentIntent.
        /// </summary>
        [JsonProperty("fleet_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("fleet_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<ChargePaymentDetailsFleetDatumOptions> FleetData
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
        public ChargePaymentDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Flight data for this PaymentIntent.
        /// </summary>
        [JsonProperty("flight_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("flight_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<ChargePaymentDetailsFlightDatumOptions> FlightData
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
        public ChargePaymentDetailsLodgingOptions Lodging { get; set; }

        /// <summary>
        /// Lodging data for this PaymentIntent.
        /// </summary>
        [JsonProperty("lodging_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("lodging_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<ChargePaymentDetailsLodgingDatumOptions> LodgingData
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
        [JsonProperty("money_services", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("money_services")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ChargePaymentDetailsMoneyServicesOptions MoneyServices
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
        [JsonProperty("order_reference", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("order_reference")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        public ChargePaymentDetailsSubscriptionOptions Subscription { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
