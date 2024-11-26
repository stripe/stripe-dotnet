// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        /// <summary>
        /// Setting to true enables installments for this PaymentIntent. This will cause the
        /// response to contain a list of available installment plans. Setting to false will prevent
        /// any selected plan from applying to a charge.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// The selected installment plan to use for this payment attempt. This parameter can only
        /// be provided during confirmation.
        /// </summary>
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}
