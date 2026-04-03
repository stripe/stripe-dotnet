// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsFleetDatumStationOptions : INestedOptions
    {
        /// <summary>
        /// Additional contact information for the station.
        /// </summary>
        [JsonProperty("additional_contact_info")]
        [STJS.JsonPropertyName("additional_contact_info")]
        public string AdditionalContactInfo { get; set; }

        /// <summary>
        /// The customer service phone number of the station.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
        [STJS.JsonPropertyName("customer_service_phone_number")]
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// The partner ID code of the station.
        /// </summary>
        [JsonProperty("partner_id_code")]
        [STJS.JsonPropertyName("partner_id_code")]
        public string PartnerIdCode { get; set; }

        /// <summary>
        /// The phone number of the station.
        /// </summary>
        [JsonProperty("phone_number")]
        [STJS.JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The physical location of the station.
        /// </summary>
        [JsonProperty("service_location")]
        [STJS.JsonPropertyName("service_location")]
        public AddressOptions ServiceLocation { get; set; }

        /// <summary>
        /// The URL of the station.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
