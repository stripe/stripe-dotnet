// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractOneTimeFee : StripeEntity<ContractOneTimeFee>
    {
        /// <summary>
        /// The resolved bill schedule for the fee.
        /// </summary>
        [JsonProperty("bill_schedule")]
        [STJS.JsonPropertyName("bill_schedule")]
        public List<ContractOneTimeFeeBillSchedule> BillSchedule { get; set; }

        /// <summary>
        /// The type of billable item that this fee references.
        /// </summary>
        [JsonProperty("billable_item_type")]
        [STJS.JsonPropertyName("billable_item_type")]
        public string BillableItemType { get; set; }

        /// <summary>
        /// Details for a product billable target. Set when <c>billable_item_type</c> is
        /// <c>product</c>.
        /// </summary>
        [JsonProperty("product_details")]
        [STJS.JsonPropertyName("product_details")]
        public ContractOneTimeFeeProductDetails ProductDetails { get; set; }
    }
}
