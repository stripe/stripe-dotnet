// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        /// <summary>
        /// Setting to true enables installments for this Checkout Session. Setting to false will
        /// prevent any installment plan from applying to a payment.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
