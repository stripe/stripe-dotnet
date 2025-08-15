// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfiguration : StripeEntity<AccountConfiguration>
    {
        /// <summary>
        /// Configuration to enable this Account to be used as a recipient of an OutboundPayment via
        /// the OutboundPayments API, or via the dashboard. This field will only be returned if
        /// <c>configuration.recipient_data</c> is passed in the <c>include</c> parameter. Note that
        /// you cannot pass the <c>include</c> parameter on list requests so this field cannot be
        /// populated for lists.
        /// </summary>
        [JsonProperty("recipient_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient_data")]
#endif
        public AccountConfigurationRecipientData RecipientData { get; set; }

        /// <summary>
        /// Supported features that can be requested for the Account's configurations. This field
        /// will only be returned if <c>supportable_features.recipient_data</c> is passed in the
        /// <c>include</c> parameter. Note that you cannot pass the <c>include</c> parameter on list
        /// requests so this field cannot be populated for lists.
        /// </summary>
        [JsonProperty("supportable_features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supportable_features")]
#endif
        public AccountConfigurationSupportableFeatures SupportableFeatures { get; set; }
    }
}
