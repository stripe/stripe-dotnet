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
        /// Required when type is 'amounts_due'.
        /// </summary>
        [JsonProperty("amounts_due")]
        [STJS.JsonPropertyName("amounts_due")]
        public PaymentPlanScheduleAmountsDueOptions AmountsDue { get; set; }

        /// <summary>
        /// The schedule type. Currently only 'amounts_due' is supported.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
