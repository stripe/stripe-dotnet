// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentPlanScheduleOptions : INestedOptions
    {
        /// <summary>
        /// Required when type is 'amounts_due'. Must contain at least two installment entries.
        /// </summary>
        [JsonProperty("amounts_due")]
        [STJS.JsonPropertyName("amounts_due")]
        public PaymentPlanScheduleAmountsDueOptions AmountsDue { get; set; }

        /// <summary>
        /// The schedule type. It only supports 'amounts_due'.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
