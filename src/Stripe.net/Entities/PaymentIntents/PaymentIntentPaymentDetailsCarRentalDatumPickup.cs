// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumPickup : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumPickup>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Name of the location.
        /// </summary>
        [JsonProperty("location_name")]
        [STJS.JsonPropertyName("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// Time associated with the location.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Time { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
