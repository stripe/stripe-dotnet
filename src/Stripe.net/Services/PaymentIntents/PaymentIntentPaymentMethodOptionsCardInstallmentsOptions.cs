// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        /// <summary>
        /// Setting to true enables installments for this PaymentIntent. This will cause the
        /// response to contain a list of available installment plans. Setting to false will prevent
        /// any selected plan from applying to a charge.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The selected installment plan to use for this payment attempt. This parameter can only
        /// be provided during confirmation.
        /// </summary>
        [JsonProperty("plan")]
        [STJS.JsonPropertyName("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}
