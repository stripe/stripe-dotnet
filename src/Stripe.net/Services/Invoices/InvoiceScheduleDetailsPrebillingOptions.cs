// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsPrebillingOptions : INestedOptions
    {
        /// <summary>
        /// The end of the prebilled time period.
        /// </summary>
        [JsonProperty("bill_until")]
        [STJS.JsonPropertyName("bill_until")]
        public InvoiceScheduleDetailsPrebillingBillUntilOptions BillUntil { get; set; }

        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
        [STJS.JsonPropertyName("iterations")]
        public long? Iterations { get; set; }
    }
}
