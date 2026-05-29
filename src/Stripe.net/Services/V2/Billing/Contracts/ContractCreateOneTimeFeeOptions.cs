// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateOneTimeFeeOptions : INestedOptions
    {
        /// <summary>
        /// The bill schedule for the fee. Each entry produces an individual invoice item billed at
        /// <c>bill_at</c>.
        /// </summary>
        [JsonProperty("bill_schedule")]
        [STJS.JsonPropertyName("bill_schedule")]
        public List<ContractCreateOneTimeFeeBillScheduleOptions> BillSchedule { get; set; }

        /// <summary>
        /// The type of billable item that this fee references.
        /// </summary>
        [JsonProperty("billable_item_type")]
        [STJS.JsonPropertyName("billable_item_type")]
        public string BillableItemType { get; set; }

        /// <summary>
        /// Details for a product billable target. Required when <c>billable_item_type</c> is
        /// <c>product</c>.
        /// </summary>
        [JsonProperty("product_details")]
        [STJS.JsonPropertyName("product_details")]
        public ContractCreateOneTimeFeeProductDetailsOptions ProductDetails { get; set; }
    }
}
