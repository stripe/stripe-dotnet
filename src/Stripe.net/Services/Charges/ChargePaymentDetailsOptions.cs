// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Car rental details for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental")]
        public ChargePaymentDetailsCarRentalOptions CarRental { get; set; }

        /// <summary>
        /// Event details for this PaymentIntent.
        /// </summary>
        [JsonProperty("event_details")]
        public ChargePaymentDetailsEventDetailsOptions EventDetails { get; set; }

        /// <summary>
        /// Flight reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("flight")]
        public ChargePaymentDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Lodging reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("lodging")]
        public ChargePaymentDetailsLodgingOptions Lodging { get; set; }

        /// <summary>
        /// Subscription details for this PaymentIntent.
        /// </summary>
        [JsonProperty("subscription")]
        public ChargePaymentDetailsSubscriptionOptions Subscription { get; set; }
    }
}
