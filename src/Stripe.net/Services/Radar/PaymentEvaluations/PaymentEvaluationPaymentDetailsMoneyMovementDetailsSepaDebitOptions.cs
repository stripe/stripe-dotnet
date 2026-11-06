// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationPaymentDetailsMoneyMovementDetailsSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// Supply the SEPA Creditor Identifier configured for the intended debit with your selected
        /// processor. Obtain it from your processor's SEPA configuration API or onboarding/support
        /// information. Do not supply a statement descriptor, IBAN, processor merchant-account ID,
        /// or mandate reference. If the creditor identifier is unknown, omit it.
        /// </summary>
        [JsonProperty("creditor_id")]
        [STJS.JsonPropertyName("creditor_id")]
        public string CreditorId { get; set; }
    }
}
