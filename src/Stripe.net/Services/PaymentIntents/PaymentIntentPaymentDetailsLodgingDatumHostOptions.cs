// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsLodgingDatumHostOptions : INestedOptions
    {
        /// <summary>
        /// Address of the host.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Host's country of domicile.
        /// </summary>
        [JsonProperty("country_of_domicile")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country_of_domicile")]
#endif
        public string CountryOfDomicile { get; set; }

        /// <summary>
        /// Reference number for the host.
        /// </summary>
        [JsonProperty("host_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("host_reference")]
#endif
        public string HostReference { get; set; }

        /// <summary>
        /// Type of host.
        /// One of: <c>hostel</c>, <c>hotel</c>, <c>owner</c>, or <c>rental_agency</c>.
        /// </summary>
        [JsonProperty("host_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("host_type")]
#endif
        public string HostType { get; set; }

        /// <summary>
        /// Name of the lodging property or host.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Total number of reservations for the host.
        /// </summary>
        [JsonProperty("number_of_reservations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number_of_reservations")]
#endif
        public long? NumberOfReservations { get; set; }

        /// <summary>
        /// Property phone number.
        /// </summary>
        [JsonProperty("property_phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("property_phone_number")]
#endif
        public string PropertyPhoneNumber { get; set; }

        /// <summary>
        /// Host's registration date.
        /// </summary>
        [JsonProperty("registered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? RegisteredAt { get; set; }
    }
}
