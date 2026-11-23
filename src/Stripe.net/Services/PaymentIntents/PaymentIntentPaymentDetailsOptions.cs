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
        private List<PaymentIntentPaymentDetailsLodgingDatumOptions> lodgingData;
        private string orderReference;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Car rental data for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("car_rental_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        /// Lodging data for this PaymentIntent.
        /// </summary>
        [JsonProperty("lodging_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("lodging_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
