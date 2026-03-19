// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsUpiOptions : INestedOptions
    {
        /// <summary>
        /// Configuration options for setting up an eMandate.
        /// </summary>
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public PaymentIntentPaymentMethodOptionsUpiMandateOptionsOptions MandateOptions { get; set; }

        /// <summary>
        /// One of: <c>none</c>, <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        [STJS.JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
