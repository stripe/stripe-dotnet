// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationFleetCardholderPromptData : StripeEntity<AuthorizationFleetCardholderPromptData>
    {
        /// <summary>
        /// [Deprecated] An alphanumeric ID, though typical point of sales only support numeric
        /// entry. The card program can be configured to prompt for a vehicle ID, driver ID, or
        /// generic ID.
        /// </summary>
        [Obsolete("This property is deprecated, please refer to the description for details.")]
        [JsonProperty("alphanumeric_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alphanumeric_id")]
#endif
        public string AlphanumericId { get; set; }

        /// <summary>
        /// Driver ID.
        /// </summary>
        [JsonProperty("driver_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("driver_id")]
#endif
        public string DriverId { get; set; }

        /// <summary>
        /// Odometer reading.
        /// </summary>
        [JsonProperty("odometer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("odometer")]
#endif
        public long? Odometer { get; set; }

        /// <summary>
        /// An alphanumeric ID. This field is used when a vehicle ID, driver ID, or generic ID is
        /// entered by the cardholder, but the merchant or card network did not specify the prompt
        /// type.
        /// </summary>
        [JsonProperty("unspecified_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unspecified_id")]
#endif
        public string UnspecifiedId { get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty("user_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_id")]
#endif
        public string UserId { get; set; }

        /// <summary>
        /// Vehicle number.
        /// </summary>
        [JsonProperty("vehicle_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vehicle_number")]
#endif
        public string VehicleNumber { get; set; }
    }
}
