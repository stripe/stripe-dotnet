// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Describes card money movement details for the payment evaluation.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentEvaluationPaymentDetailsMoneyMovementDetailsCardOptions Card { get; set; }

        /// <summary>
        /// Describes the type of money movement. Currently only <c>card</c> is supported.
        /// </summary>
        [JsonProperty("money_movement_type")]
        [STJS.JsonPropertyName("money_movement_type")]
        public string MoneyMovementType { get; set; }
    }
}
