// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantCardPayments : StripeEntity<AccountConfigurationMerchantCardPayments>
    {
        /// <summary>
        /// Automatically declines certain charge types regardless of whether the card issuer
        /// accepted or declined the charge.
        /// </summary>
        [JsonProperty("decline_on")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("decline_on")]
#endif
        public AccountConfigurationMerchantCardPaymentsDeclineOn DeclineOn { get; set; }
    }
}
