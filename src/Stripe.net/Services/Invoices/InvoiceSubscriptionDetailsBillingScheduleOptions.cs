// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceSubscriptionDetailsBillingScheduleOptions : INestedOptions
    {
        /// <summary>
        /// Configure billing schedule differently for individual subscription items.
        /// </summary>
        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public List<InvoiceSubscriptionDetailsBillingScheduleAppliesToOptions> AppliesTo { get; set; }

        /// <summary>
        /// The end date for the billing schedule.
        /// </summary>
        [JsonProperty("bill_until")]
        [STJS.JsonPropertyName("bill_until")]
        public InvoiceSubscriptionDetailsBillingScheduleBillUntilOptions BillUntil { get; set; }

        /// <summary>
        /// Specify a key for the billing schedule. Must be unique to this field, alphanumeric, and
        /// up to 200 characters. If not provided, a unique key will be generated.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
