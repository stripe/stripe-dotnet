// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsCarRentalDatumDropOffOptions : INestedOptions
    {
        /// <summary>
        /// Address of the rental location.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Location name.
        /// </summary>
        [JsonProperty("location_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location_name")]
#endif
        public string LocationName { get; set; }

        /// <summary>
        /// Timestamp for the location.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Time { get; set; }
    }
}
