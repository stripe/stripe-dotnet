// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebit : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebit>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("debit_behavior")]
        [STJS.JsonPropertyName("debit_behavior")]
        public string DebitBehavior { get; set; }
    }
}
