// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemParent : StripeEntity<InvoiceLineItemParent>
    {
        /// <summary>
        /// Details about the invoice item that generated this line item.
        /// </summary>
        [JsonProperty("invoice_item_details")]
        [STJS.JsonPropertyName("invoice_item_details")]
        public InvoiceLineItemParentInvoiceItemDetails InvoiceItemDetails { get; set; }

        /// <summary>
        /// Details about the rate card subscription that generated this line item.
        /// </summary>
        [JsonProperty("rate_card_subscription_details")]
        [STJS.JsonPropertyName("rate_card_subscription_details")]
        public InvoiceLineItemParentRateCardSubscriptionDetails RateCardSubscriptionDetails { get; set; }

        /// <summary>
        /// Details about the subscription schedule that generated this line item.
        /// </summary>
        [JsonProperty("schedule_details")]
        [STJS.JsonPropertyName("schedule_details")]
        public InvoiceLineItemParentScheduleDetails ScheduleDetails { get; set; }

        /// <summary>
        /// Details about the subscription item that generated this line item.
        /// </summary>
        [JsonProperty("subscription_item_details")]
        [STJS.JsonPropertyName("subscription_item_details")]
        public InvoiceLineItemParentSubscriptionItemDetails SubscriptionItemDetails { get; set; }

        /// <summary>
        /// The type of parent that generated this line item.
        /// One of: <c>invoice_item_details</c>, <c>pricing_plan_subscription_details</c>,
        /// <c>rate_card_subscription_details</c>, <c>schedule_details</c>, or
        /// <c>subscription_item_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Details about the pricing plan subscription that generated this line item.
        /// </summary>
        [JsonProperty("pricing_plan_subscription_details")]
        [STJS.JsonPropertyName("pricing_plan_subscription_details")]
        public InvoiceLineItemParentPricingPlanSubscriptionDetails PricingPlanSubscriptionDetails { get; set; }
    }
}
