// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractOneTimeFeesData : StripeEntity<ContractOneTimeFeesData>, IHasId
    {
        /// <summary>
        /// The resolved bill schedule for the fee.
        /// </summary>
        [JsonProperty("bill_schedule")]
        [STJS.JsonPropertyName("bill_schedule")]
        public List<ContractOneTimeFeesDataBillSchedule> BillSchedule { get; set; }

        /// <summary>
        /// The type of billable item that this fee references.
        /// </summary>
        [JsonProperty("billable_item_type")]
        [STJS.JsonPropertyName("billable_item_type")]
        public string BillableItemType { get; set; }

        /// <summary>
        /// The ID of the one-time fee.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The user-provided lookup key.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Details for a product billable target. Set when <c>billable_item_type</c> is
        /// <c>product</c>.
        /// </summary>
        [JsonProperty("product_details")]
        [STJS.JsonPropertyName("product_details")]
        public ContractOneTimeFeesDataProductDetails ProductDetails { get; set; }
    }
}
