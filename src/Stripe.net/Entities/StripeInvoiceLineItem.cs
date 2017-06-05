using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeInvoiceLineItem : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer
        public string CustomerId { get; set; }

        [JsonIgnore]
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                StringOrObject<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
            }
        }
        #endregion

        [JsonProperty("date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("proration")]
        public bool Proration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Invoice
        public string InvoiceId { get; set; }

        [JsonIgnore]
        public StripeInvoice Invoice { get; set; }

        [JsonProperty("invoice")]
        internal object InternalInvoice
        {
            set
            {
                StringOrObject<StripeInvoice>.Map(value, s => InvoiceId = s, o => Invoice = o);
            }
        }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public StripePlan Plan { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("period")]
        public StripePeriod StripePeriod { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}