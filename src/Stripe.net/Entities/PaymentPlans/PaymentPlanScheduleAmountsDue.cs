// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentPlanScheduleAmountsDue : StripeEntity<PaymentPlanScheduleAmountsDue>
    {
        /// <summary>
        /// The list of installment schedule entries.
        /// </summary>
        [JsonProperty("amounts")]
        [STJS.JsonPropertyName("amounts")]
        public List<PaymentPlanScheduleAmountsDueAmount> Amounts { get; set; }
    }
}
