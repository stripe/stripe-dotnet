// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsLodgingDatumHostOptions : INestedOptions
    {
        /// <summary>
        /// Address of the host.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Host's country of domicile.
        /// </summary>
        [JsonProperty("country_of_domicile")]
        [STJS.JsonPropertyName("country_of_domicile")]
        public string CountryOfDomicile { get; set; }

        /// <summary>
        /// Reference number for the host.
        /// </summary>
        [JsonProperty("host_reference")]
        [STJS.JsonPropertyName("host_reference")]
        public string HostReference { get; set; }

        /// <summary>
        /// Type of host.
        /// One of: <c>hostel</c>, <c>hotel</c>, <c>owner</c>, or <c>rental_agency</c>.
        /// </summary>
        [JsonProperty("host_type")]
        [STJS.JsonPropertyName("host_type")]
        public string HostType { get; set; }

        /// <summary>
        /// Name of the lodging property or host.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Total number of reservations for the host.
        /// </summary>
        [JsonProperty("number_of_reservations")]
        [STJS.JsonPropertyName("number_of_reservations")]
        public long? NumberOfReservations { get; set; }

        /// <summary>
        /// Property phone number.
        /// </summary>
        [JsonProperty("property_phone_number")]
        [STJS.JsonPropertyName("property_phone_number")]
        public string PropertyPhoneNumber { get; set; }

        /// <summary>
        /// Host's registration date.
        /// </summary>
        [JsonProperty("registered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("registered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? RegisteredAt { get; set; }
    }
}
