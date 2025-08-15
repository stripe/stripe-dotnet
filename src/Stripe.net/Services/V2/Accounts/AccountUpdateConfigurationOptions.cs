// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationOptions : INestedOptions
    {
        /// <summary>
        /// Configuration to enable this Account to be used as a recipient of an OutboundPayment via
        /// the OutboundPayments API, or via the dashboard.
        /// </summary>
        [JsonProperty("recipient_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient_data")]
#endif
        public AccountUpdateConfigurationRecipientDataOptions RecipientData { get; set; }
    }
}
