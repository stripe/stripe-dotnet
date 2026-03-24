// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantCardPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Automatically declines certain charge types regardless of whether the card issuer
        /// accepted or declined the charge.
        /// </summary>
        [JsonProperty("decline_on")]
        [STJS.JsonPropertyName("decline_on")]
        public AccountCreateConfigurationMerchantCardPaymentsDeclineOnOptions DeclineOn { get; set; }
    }
}
