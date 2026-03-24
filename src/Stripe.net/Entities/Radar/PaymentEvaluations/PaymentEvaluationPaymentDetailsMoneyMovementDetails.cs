// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationPaymentDetailsMoneyMovementDetails : StripeEntity<PaymentEvaluationPaymentDetailsMoneyMovementDetails>
    {
        /// <summary>
        /// Describes card money movement details for the payment evaluation.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentEvaluationPaymentDetailsMoneyMovementDetailsCard Card { get; set; }

        /// <summary>
        /// Describes the type of money movement. Currently only <c>card</c> is supported.
        /// </summary>
        [JsonProperty("money_movement_type")]
        [STJS.JsonPropertyName("money_movement_type")]
        public string MoneyMovementType { get; set; }
    }
}
