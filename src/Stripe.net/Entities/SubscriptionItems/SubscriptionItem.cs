namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItem : StripeEntity<SubscriptionItem>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the related subscription
        /// advanced to a new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// You can now model subscriptions more flexibly using the <a
        /// href="https://stripe.com/docs/api#prices">Prices API</a>. It replaces the Plans API and
        /// is backwards compatible to simplify your migration.
        ///
        /// Plans define the base price, currency, and billing cycle for recurring purchases of
        /// products. <a href="https://stripe.com/docs/api#products">Products</a> help you track
        /// inventory or provisioning, and plans help you track pricing. Different physical goods or
        /// levels of service should be represented by products, and pricing options should be
        /// represented by plans. This approach lets you change prices without having to change your
        /// provisioning scheme.
        ///
        /// For example, you might have a single "gold" product that has plans for $10/month,
        /// $100/year, €9/month, and €90/year.
        ///
        /// Related guides: <a
        /// href="https://stripe.com/docs/billing/subscriptions/set-up-subscription">Set up a
        /// subscription</a> and more about <a
        /// href="https://stripe.com/docs/billing/prices-guide">products and prices</a>.
        /// </summary>
        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Prices define the unit cost, currency, and (optional) billing cycle for both recurring
        /// and one-time purchases of products. <a
        /// href="https://stripe.com/docs/api#products">Products</a> help you track inventory or
        /// provisioning, and prices help you track payment terms. Different physical goods or
        /// levels of service should be represented by products, and pricing options should be
        /// represented by prices. This approach lets you change prices without having to change
        /// your provisioning scheme.
        ///
        /// For example, you might have a single "gold" product that has prices for $10/month,
        /// $100/year, and €9 once.
        ///
        /// Related guides: <a
        /// href="https://stripe.com/docs/billing/subscriptions/set-up-subscription">Set up a
        /// subscription</a>, <a href="https://stripe.com/docs/billing/invoices/create">create an
        /// invoice</a>, and more about <a
        /// href="https://stripe.com/docs/billing/prices-guide">products and prices</a>.
        /// </summary>
        [JsonProperty("price")]
        public Price Price { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/subscriptions/quantities">quantity</a> of the plan
        /// to which the customer should be subscribed.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The <c>subscription</c> this <c>subscription_item</c> belongs to.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The tax rates which apply to this <c>subscription_item</c>. When set, the
        /// <c>default_tax_rates</c> on the subscription do not apply to this
        /// <c>subscription_item</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }
    }
}
