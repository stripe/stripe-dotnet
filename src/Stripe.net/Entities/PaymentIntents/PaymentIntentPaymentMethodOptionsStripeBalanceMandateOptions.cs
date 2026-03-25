// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsStripeBalanceMandateOptions : StripeEntity<PaymentIntentPaymentMethodOptionsStripeBalanceMandateOptions>
    {
        /// <summary>
        /// The ID of the Stripe Balance Debit Agreement used for this mandate.
        /// </summary>
        [JsonProperty("stripe_balance_debit_agreement")]
        [STJS.JsonPropertyName("stripe_balance_debit_agreement")]
        public string StripeBalanceDebitAgreement { get; set; }
    }
}
