// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Car rental details for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental")]
        public PaymentIntentPaymentDetailsCarRentalOptions CarRental { get; set; }

        /// <summary>
        /// Event details for this PaymentIntent.
        /// </summary>
        [JsonProperty("event_details")]
        public PaymentIntentPaymentDetailsEventDetailsOptions EventDetails { get; set; }

        /// <summary>
        /// Flight reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("flight")]
        public PaymentIntentPaymentDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Lodging reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("lodging")]
        public PaymentIntentPaymentDetailsLodgingOptions Lodging { get; set; }

        /// <summary>
        /// Subscription details for this PaymentIntent.
        /// </summary>
        [JsonProperty("subscription")]
        public PaymentIntentPaymentDetailsSubscriptionOptions Subscription { get; set; }
    }
}
