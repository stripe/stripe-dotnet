// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumDropOffOptions : INestedOptions
    {
        /// <summary>
        /// Address of the rental location.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Location name.
        /// </summary>
        [JsonProperty("location_name")]
        [STJS.JsonPropertyName("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// Timestamp for the location.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Time { get; set; }
    }
}
