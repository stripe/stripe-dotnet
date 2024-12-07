namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    [Obsolete("Use InvoiceLineItemListOptions instead.")]
    public class InvoiceListLineItemsOptions : ListOptions
    {
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }

        [JsonProperty("subscription_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_items")]
#endif
        public List<InvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [JsonProperty("subscription_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_plan")]
#endif
        public string SubscriptionPlan { get; set; }
    }
}
