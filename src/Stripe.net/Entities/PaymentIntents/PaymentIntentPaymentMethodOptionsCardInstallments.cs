// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCardInstallments : StripeEntity<PaymentIntentPaymentMethodOptionsCardInstallments>
    {
        /// <summary>
        /// Installment plans that may be selected for this PaymentIntent.
        /// </summary>
        [JsonProperty("available_plans")]
        [STJS.JsonPropertyName("available_plans")]
        public List<PaymentIntentPaymentMethodOptionsCardInstallmentsPlan> AvailablePlans { get; set; }

        /// <summary>
        /// Whether Installments are enabled for this PaymentIntent.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Installment plan selected for this PaymentIntent.
        /// </summary>
        [JsonProperty("plan")]
        [STJS.JsonPropertyName("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
