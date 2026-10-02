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
        /// Describes card money movement details.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentEvaluationPaymentDetailsMoneyMovementDetailsCard Card { get; set; }

        /// <summary>
        /// Describes the type of money movement.
        /// One of: <c>card</c>, or <c>us_bank_account</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("money_movement_type")]
        [STJS.JsonPropertyName("money_movement_type")]
        public string MoneyMovementType { get; set; }

        /// <summary>
        /// Describes US bank account money movement details.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public PaymentEvaluationPaymentDetailsMoneyMovementDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
