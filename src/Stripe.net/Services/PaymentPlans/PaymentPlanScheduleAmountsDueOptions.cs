// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentPlanScheduleAmountsDueOptions : INestedOptions
    {
        /// <summary>
        /// The list of installment entries.
        /// </summary>
        [JsonProperty("amounts")]
        [STJS.JsonPropertyName("amounts")]
        public List<PaymentPlanScheduleAmountsDueAmountOptions> Amounts { get; set; }
    }
}
