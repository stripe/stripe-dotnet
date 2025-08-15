// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationSupportableFeatures : StripeEntity<AccountConfigurationSupportableFeatures>
    {
        /// <summary>
        /// Closed Enum. A list of supported features that can be requested when the Account is
        /// configured as a recipient. Will be unset unless Legal Entity country has been provided
        /// for this Account.
        /// One of: <c>bank_accounts.local</c>, <c>bank_accounts.wire</c>, or <c>cards</c>.
        /// </summary>
        [JsonProperty("recipient_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient_data")]
#endif
        public List<string> RecipientData { get; set; }
    }
}
