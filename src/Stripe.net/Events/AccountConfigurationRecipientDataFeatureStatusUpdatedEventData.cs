// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientDataFeatureStatusUpdatedEventData : StripeEntity<AccountConfigurationRecipientDataFeatureStatusUpdatedEventData>
    {
        /// <summary>
        /// Closed Enum. The recipient_data feature which had its status updated.
        /// One of: <c>bank_accounts.local</c>, <c>bank_accounts.wire</c>, or <c>cards</c>.
        /// </summary>
        [JsonProperty("feature_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("feature_name")]
#endif
        public string FeatureName { get; set; }
    }
}
