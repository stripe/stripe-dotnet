// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutIntentCreateToPayoutMethodOptionsBankAccountPreferredNetworkOptionsOptions : INestedOptions
    {
        /// <summary>
        /// ACH-specific network options.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public PayoutIntentCreateToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAchOptions Ach { get; set; }
    }
}
