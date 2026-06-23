namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    [Obsolete("Use InvoiceLineItemListOptions instead.")]
    public class InvoiceListLineItemsOptions : ListOptions
    {
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("subscription_plan")]
        [STJS.JsonPropertyName("subscription_plan")]
        public string SubscriptionPlan { get; set; }
    }
}
