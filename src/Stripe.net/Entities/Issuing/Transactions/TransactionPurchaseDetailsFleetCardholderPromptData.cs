// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionPurchaseDetailsFleetCardholderPromptData : StripeEntity<TransactionPurchaseDetailsFleetCardholderPromptData>
    {
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
