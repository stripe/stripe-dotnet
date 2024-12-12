// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Car rental details for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("car_rental")]
#endif
        public PaymentIntentPaymentDetailsCarRentalOptions CarRental { get; set; }

        /// <summary>
        /// Event details for this PaymentIntent.
        /// </summary>
        [JsonProperty("event_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_details")]
#endif
        public PaymentIntentPaymentDetailsEventDetailsOptions EventDetails { get; set; }

        /// <summary>
        /// Flight reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("flight")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flight")]
#endif
        public PaymentIntentPaymentDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Lodging reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("lodging")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lodging")]
#endif
        public PaymentIntentPaymentDetailsLodgingOptions Lodging { get; set; }

        /// <summary>
        /// Subscription details for this PaymentIntent.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public PaymentIntentPaymentDetailsSubscriptionOptions Subscription { get; set; }
    }
}
