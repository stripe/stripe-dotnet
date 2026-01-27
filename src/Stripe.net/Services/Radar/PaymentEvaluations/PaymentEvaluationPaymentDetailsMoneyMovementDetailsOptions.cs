// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Describes card money movement details for the payment evaluation.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentEvaluationPaymentDetailsMoneyMovementDetailsCardOptions Card { get; set; }

        /// <summary>
        /// Describes the type of money movement. Currently only <c>card</c> is supported.
        /// </summary>
        [JsonProperty("money_movement_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("money_movement_type")]
#endif
        public string MoneyMovementType { get; set; }
    }
}
