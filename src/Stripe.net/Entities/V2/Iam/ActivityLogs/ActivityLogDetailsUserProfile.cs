// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserProfile : StripeEntity<ActivityLogDetailsUserProfile>
    {
        /// <summary>
        /// Email address after the change.
        /// </summary>
        [JsonProperty("new_email")]
        [STJS.JsonPropertyName("new_email")]
        public string NewEmail { get; set; }

        /// <summary>
        /// Redacted phone number after the change.
        /// </summary>
        [JsonProperty("new_redacted_phone_number")]
        [STJS.JsonPropertyName("new_redacted_phone_number")]
        public string NewRedactedPhoneNumber { get; set; }

        /// <summary>
        /// Email address before the change.
        /// </summary>
        [JsonProperty("old_email")]
        [STJS.JsonPropertyName("old_email")]
        public string OldEmail { get; set; }

        /// <summary>
        /// Redacted phone number before the change.
        /// </summary>
        [JsonProperty("old_redacted_phone_number")]
        [STJS.JsonPropertyName("old_redacted_phone_number")]
        public string OldRedactedPhoneNumber { get; set; }
    }
}
