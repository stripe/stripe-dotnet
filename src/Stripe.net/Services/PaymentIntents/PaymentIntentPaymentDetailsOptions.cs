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
        private string customerReference;
        private string orderReference;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

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
        public List<PaymentIntentPaymentDetailsCarRentalDatumOptions> CarRentalData { get; set; }

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
        public List<PaymentIntentPaymentDetailsFlightDatumOptions> FlightData { get; set; }

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
        public List<PaymentIntentPaymentDetailsLodgingDatumOptions> LodgingData { get; set; }

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
        public string OrderReference { get; set; }

        /// <summary>
        /// Subscription details for this PaymentIntent.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public PaymentIntentPaymentDetailsSubscriptionOptions Subscription { get; set; }
    }
}
