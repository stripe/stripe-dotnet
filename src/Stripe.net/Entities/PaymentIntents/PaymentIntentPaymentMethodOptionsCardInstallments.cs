// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsCardInstallments : StripeEntity<PaymentIntentPaymentMethodOptionsCardInstallments>
    {
        /// <summary>
        /// Installment plans that may be selected for this PaymentIntent.
        /// </summary>
        [JsonProperty("available_plans")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available_plans")]
#endif
        public List<PaymentIntentPaymentMethodOptionsCardInstallmentsPlan> AvailablePlans { get; set; }

        /// <summary>
        /// Whether Installments are enabled for this PaymentIntent.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// Installment plan selected for this PaymentIntent.
        /// </summary>
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
