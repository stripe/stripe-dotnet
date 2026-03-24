// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsManualEntry : StripeEntity<SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsManualEntry>
    {
        /// <summary>
        /// Settings for configuring manual entry of account details.
        /// One of: <c>automatic</c>, or <c>custom</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}
