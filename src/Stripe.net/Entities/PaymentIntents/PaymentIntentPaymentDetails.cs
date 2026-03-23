// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetails : StripeEntity<PaymentIntentPaymentDetails>
    {
        [JsonProperty("car_rental")]
        [STJS.JsonPropertyName("car_rental")]
        public PaymentIntentPaymentDetailsCarRental CarRental { get; set; }

        [JsonProperty("car_rental_data")]
        [STJS.JsonPropertyName("car_rental_data")]
        public List<PaymentIntentPaymentDetailsCarRentalDatum> CarRentalData { get; set; }

        /// <summary>
        /// A unique value to identify the customer. This field is available only for card payments.
        ///
        /// This field is truncated to 25 alphanumeric characters, excluding spaces, before being
        /// sent to card networks.
        /// </summary>
        [JsonProperty("customer_reference")]
        [STJS.JsonPropertyName("customer_reference")]
        public string CustomerReference { get; set; }

        [JsonProperty("event_details")]
        [STJS.JsonPropertyName("event_details")]
        public PaymentIntentPaymentDetailsEventDetails EventDetails { get; set; }

        [JsonProperty("flight_data")]
        [STJS.JsonPropertyName("flight_data")]
        public List<PaymentIntentPaymentDetailsFlightDatum> FlightData { get; set; }

        [JsonProperty("lodging_data")]
        [STJS.JsonPropertyName("lodging_data")]
        public List<PaymentIntentPaymentDetailsLodgingDatum> LodgingData { get; set; }

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

        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public PaymentIntentPaymentDetailsSubscription Subscription { get; set; }
    }
}
