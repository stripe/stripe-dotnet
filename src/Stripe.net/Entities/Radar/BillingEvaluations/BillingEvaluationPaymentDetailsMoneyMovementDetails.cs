// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BillingEvaluationPaymentDetailsMoneyMovementDetails : StripeEntity<BillingEvaluationPaymentDetailsMoneyMovementDetails>
    {
        /// <summary>
        /// Describes card money movement details.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public BillingEvaluationPaymentDetailsMoneyMovementDetailsCard Card { get; set; }

        /// <summary>
        /// Describes the type of money movement. Currently only <c>card</c> is supported.
        /// </summary>
        [JsonProperty("money_movement_type")]
        [STJS.JsonPropertyName("money_movement_type")]
        public string MoneyMovementType { get; set; }
    }
}
